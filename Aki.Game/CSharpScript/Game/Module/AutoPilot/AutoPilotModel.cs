using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Infrastructure;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Transport;
using CSharpScript.Game.NewWorld.Vehicle.Motorcycle;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02004E55 RID: 20053
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class AutoPilotModel : ModelBase
	{
		// Token: 0x1700624D RID: 25165
		// (get) Token: 0x0603273B RID: 206651 RVA: 0x00E27876 File Offset: 0x00E25A76
		[Nullable(2)]
		public CharacterActorComponent ActorComp
		{
			[NullableContext(2)]
			get
			{
				SceneTeamModel instance = SceneTeamModel.Instance;
				if (instance == null)
				{
					return null;
				}
				EntityHandle getCurrentEntity = instance.GetCurrentEntity;
				if (getCurrentEntity == null)
				{
					return null;
				}
				WorldEntity entity = getCurrentEntity.Entity;
				if (entity == null)
				{
					return null;
				}
				return entity.GetComponent<CharacterActorComponent>();
			}
		}

		// Token: 0x0603273C RID: 206652 RVA: 0x00E2789E File Offset: 0x00E25A9E
		protected override bool OnInit()
		{
			this.InitParameters();
			this.AddEvents();
			return true;
		}

		// Token: 0x0603273D RID: 206653 RVA: 0x00E278AD File Offset: 0x00E25AAD
		private void AddEvents()
		{
			EventSystem.Instance.Add<ITrackData>(EEventName.UnTrackMark, new Action<ITrackData>(this.OnUnTrackMark));
			EventSystem.Instance.Add<bool, bool>(EEventName.OnMovieMotorRideSharingModeChangeResponse, new Action<bool, bool>(this.OnMovieMotorRideSharingModeChangeResponse));
		}

		// Token: 0x0603273E RID: 206654 RVA: 0x00E278E8 File Offset: 0x00E25AE8
		private void InitParameters()
		{
			this.PlayerToTargetDistanceThreshold = Math.Pow((double)ConfigCommonParamById.GetIntConfig("AutoPilotPlayerToTargetDistanceThreshold").GetValueOrDefault(), 2.0);
			this.SplineDistanceThreshold = (double)ConfigCommonParamById.GetIntConfig("AutoPilotSplineDistanceThreshold").GetValueOrDefault();
			this.SkillHighLightTime = ConfigCommonParamById.GetIntConfig("AutoPilotSkillHighLightTime").GetValueOrDefault(-1);
			this.EnterMovieModeTimeThreshold = ConfigCommonParamById.GetIntConfig("AutoPilotEnterMovieModeTimeThreshold").GetValueOrDefault();
			this.EnterMovieModeDistanceThreshold = Math.Pow((double)ConfigCommonParamById.GetIntConfig("AutoPilotEnterMovieModeDistanceThreshold").GetValueOrDefault(), 2.0);
			this.CanSkipTimeThreshold = ConfigCommonParamById.GetIntConfig("AutoPilotCanSkipTimeThreshold").GetValueOrDefault();
			this.CanSkipDistanceThreshold = Math.Pow((double)ConfigCommonParamById.GetIntConfig("AutoPilotCanSkipDistanceThreshold").GetValueOrDefault(), 2.0);
			this.IsAllowExitByMove = ConfigCommonParamById.GetBoolConfig("AutoPilotExitByMove").GetValueOrDefault();
			this.AutoPilotRoadWayWidthOffset = (double)ConfigCommonParamById.GetIntConfig("AutoPilotRoadWayWidthOffset").GetValueOrDefault();
			this.AutoPilotExitHorizontalDistThreshold = Math.Pow((double)ConfigCommonParamById.GetIntConfig("AutoPilotExitHorizontalDistanceThreshold").GetValueOrDefault(1800), 2.0);
			this.AutoPilotExitVerticalDistThreshold = (double)ConfigCommonParamById.GetIntConfig("AutoPilotExitVerticalDistanceThreshold").GetValueOrDefault(1200);
			this.HighLightSampleDist = (double)AutoPilotDefine.HIGHLIGHTLINEDISTANCEINTERVAL;
			IReadOnlyList<string> stringArrayConfig = ConfigCommonParamById.GetStringArrayConfig("AutoPilotMovieCameraRowName");
			if (stringArrayConfig != null)
			{
				foreach (string item in stringArrayConfig)
				{
					this.MovieModeCameraRowNameArray.Add(item);
				}
			}
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("AutoPilotStuckSpeedThreshold").GetValueOrDefault();
			this.AutoPilotStuckSpeedThreshold = (double)valueOrDefault * (double)valueOrDefault;
			this.AutoPilotStuckTimeThreshold = (double)ConfigCommonParamById.GetIntConfig("AutoPilotStuckTimeThreshold").GetValueOrDefault();
			this.AutoPilotStuckStepDistance = (double)ConfigCommonParamById.GetIntConfig("AutoPilotStuckStepDistance").GetValueOrDefault();
			this.UpdateCirclePathData();
		}

		// Token: 0x0603273F RID: 206655 RVA: 0x00E27B00 File Offset: 0x00E25D00
		public unsafe void UpdateCirclePathData()
		{
			this.MapIdToCirclePathMap.Clear();
			Dictionary<int, AutoPilotDefine.IAutoPilotCircles> mapIdToCirclePathMap = this.MapIdToCirclePathMap;
			int key = 105;
			AutoPilotCircles autoPilotCircles = new AutoPilotCircles();
			int num = 1;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int num2 = 0;
			*span[num2] = 0;
			autoPilotCircles.RoadBuildIdArray = list;
			num2 = 1;
			List<int> list2 = new List<int>(num2);
			CollectionsMarshal.SetCount<int>(list2, num2);
			span = CollectionsMarshal.AsSpan<int>(list2);
			num = 0;
			*span[num] = 0;
			autoPilotCircles.CircleIds = list2;
			mapIdToCirclePathMap[key] = autoPilotCircles;
			InfrastructureConfig instance = InfrastructureConfig.Instance;
			IReadOnlyList<InfrAutoPilotCircle> readOnlyList = (instance != null) ? instance.GetAutoPilotCircle() : null;
			if (readOnlyList == null || readOnlyList.Count <= 0)
			{
				return;
			}
			foreach (InfrAutoPilotCircle infrAutoPilotCircle in readOnlyList)
			{
				if (this.IsRoadConfigValid(infrAutoPilotCircle.RoadBuildIdArray()))
				{
					int mapId = infrAutoPilotCircle.MapId;
					int autoPilotCirclePathId = infrAutoPilotCircle.AutoPilotCirclePathId;
					if (!this.MapIdToCirclePathMap.ContainsKey(mapId))
					{
						Dictionary<int, AutoPilotDefine.IAutoPilotCircles> mapIdToCirclePathMap2 = this.MapIdToCirclePathMap;
						int key2 = mapId;
						AutoPilotCircles autoPilotCircles2 = new AutoPilotCircles();
						autoPilotCircles2.RoadBuildIdArray = infrAutoPilotCircle.RoadBuildIdArrayIter().ToList<int>();
						num = 1;
						List<int> list3 = new List<int>(num);
						CollectionsMarshal.SetCount<int>(list3, num);
						span = CollectionsMarshal.AsSpan<int>(list3);
						num2 = 0;
						*span[num2] = autoPilotCirclePathId;
						autoPilotCircles2.CircleIds = list3;
						mapIdToCirclePathMap2[key2] = autoPilotCircles2;
					}
					else
					{
						AutoPilotDefine.IAutoPilotCircles autoPilotCircles3 = this.MapIdToCirclePathMap[mapId];
						if (infrAutoPilotCircle.RoadBuildIdArrayLength > autoPilotCircles3.RoadBuildIdArray.Count)
						{
							autoPilotCircles3.RoadBuildIdArray = new List<int>(infrAutoPilotCircle.RoadBuildIdArrayIter());
							autoPilotCircles3.CircleIds.Clear();
							autoPilotCircles3.CircleIds.Add(autoPilotCirclePathId);
						}
						else if (infrAutoPilotCircle.RoadBuildIdArrayLength == autoPilotCircles3.RoadBuildIdArray.Count)
						{
							autoPilotCircles3.CircleIds.Add(autoPilotCirclePathId);
						}
					}
				}
			}
		}

		// Token: 0x06032740 RID: 206656 RVA: 0x00E27CE0 File Offset: 0x00E25EE0
		private bool IsRoadConfigValid(int[] roadBuildIdArray)
		{
			foreach (int roadId in roadBuildIdArray)
			{
				InfrastructureModel instance = InfrastructureModel.Instance;
				InfrastructureDefine.IInfrRoadData infrRoadData = (instance != null) ? instance.GetRoadDataByRoadId(roadId) : null;
				if (infrRoadData == null || infrRoadData.Status != InfrStatusPb.InfrStatusComplete)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06032741 RID: 206657 RVA: 0x00E27D23 File Offset: 0x00E25F23
		public bool GetIsTracking(int markId)
		{
			MarkItem trackingMarkItem = this.TrackingMarkItem;
			return trackingMarkItem != null && trackingMarkItem.MarkId == markId;
		}

		// Token: 0x06032742 RID: 206658 RVA: 0x00E27D3C File Offset: 0x00E25F3C
		[NullableContext(2)]
		public void SetTrackingMarkItem(MarkItem markItem)
		{
			if (this.TrackingMarkItem != null && markItem != null && this.TrackingMarkItem.MarkId == markItem.MarkId)
			{
				return;
			}
			this.ClearTrackingData();
			MarkItem trackingMarkItem = this.TrackingMarkItem;
			this.TrackingMarkItem = markItem;
			if (this.TrackingMarkItem != null)
			{
				this.SetTrackingData(new AutoPilotTrackingData
				{
					TargetPos = this.TrackingMarkItem.WorldPosition,
					MapId = this.TrackingMarkItem.MapId
				});
				EventSystem.Instance.Emit<EMarkType, int>(EEventName.OnMarkItemAutoPilotTrackStateChange, this.TrackingMarkItem.MarkType, this.TrackingMarkItem.MarkId);
			}
			if (trackingMarkItem != null)
			{
				EventSystem.Instance.Emit<EMarkType, int>(EEventName.OnMarkItemAutoPilotTrackStateChange, trackingMarkItem.MarkType, trackingMarkItem.MarkId);
			}
		}

		// Token: 0x06032743 RID: 206659 RVA: 0x00E27DF6 File Offset: 0x00E25FF6
		public void ClearData()
		{
			this.ClearTrackingData();
			this.ClearCirclePathResult();
		}

		// Token: 0x06032744 RID: 206660 RVA: 0x00E27E04 File Offset: 0x00E26004
		public void ClearFindPathResult()
		{
			AutoPilotFindPathResult findPathResult = this.FindPathResult;
			if (findPathResult != null)
			{
				findPathResult.Clear();
			}
			this.FindPathResult = null;
		}

		// Token: 0x06032745 RID: 206661 RVA: 0x00E27E1E File Offset: 0x00E2601E
		public void ClearCirclePathResult()
		{
			this.CirclePathResult = null;
		}

		// Token: 0x06032746 RID: 206662 RVA: 0x00E27E28 File Offset: 0x00E26028
		public void SetTrackingData(AutoPilotDefine.IAutoPilotTrackingData trackingData)
		{
			this.TrackingData = trackingData;
			this.RefreshFindPath(null);
			EventSystem.Instance.Emit(EEventName.OnUpdateAutoPilotLine);
			AutoPilotController.Instance.AddTick(new Action<float?>(this.RefreshFindPath));
		}

		// Token: 0x06032747 RID: 206663 RVA: 0x00E27E74 File Offset: 0x00E26074
		public void ClearTrackingData()
		{
			AutoPilotController.Instance.ExitAutoPilot("ClearTrackingData", false);
			this.TrackingData = null;
			this.ClearFindPathResult();
			EventSystem.Instance.Emit(EEventName.OnUpdateAutoPilotLine);
			AutoPilotController.Instance.RemoveTick(new Action<float?>(this.RefreshFindPath));
		}

		// Token: 0x06032748 RID: 206664 RVA: 0x00E27EC5 File Offset: 0x00E260C5
		public double GetSplineDistanceThreshold()
		{
			return this.SplineDistanceThreshold;
		}

		// Token: 0x06032749 RID: 206665 RVA: 0x00E27ECD File Offset: 0x00E260CD
		[NullableContext(2)]
		public AutoPilotFindPathResult GetFindPathResult()
		{
			return this.FindPathResult;
		}

		// Token: 0x0603274A RID: 206666 RVA: 0x00E27ED5 File Offset: 0x00E260D5
		[NullableContext(2)]
		public AutoPilotCirclePathResult GetCirclePathResult()
		{
			return this.CirclePathResult;
		}

		// Token: 0x0603274B RID: 206667 RVA: 0x00E27EE0 File Offset: 0x00E260E0
		public void RefreshFindPath(float? _ = null)
		{
			if (this.ActorComp == null)
			{
				return;
			}
			bool flag = false;
			if (this.FindPathResult == null)
			{
				this.FindPathResult = new AutoPilotFindPathResult();
				flag = true;
			}
			if (this.IsInAutoPilotInner)
			{
				this.FindPathResult.RefreshDataInAutoPilot();
				return;
			}
			if (!flag && !this.FindPathResult.IsNeedRefreshByFindPath(this.ActorComp.ActorLocationProxy))
			{
				return;
			}
			if (!this.CheckPlayerToTargetDistanceValid(this.TrackingData.TargetPos))
			{
				this.SetTrackingMarkItem(null);
				ScrollingTipsController.Instance.ShowTipsByTextId(AutoPilotDefine.EAutoPilotTextId.TextCancelAutoPilotTooNearTips, Array.Empty<object>());
				return;
			}
			global::Vector targetPos = this.TrackingData.TargetPos;
			ITransportFindPathResult transportFindPathResult = TransportNetworkController.Instance.FindPath(this.ActorComp.ActorLocationProxy, targetPos, true, false, this.IsDebugMode);
			if (transportFindPathResult == null)
			{
				Log.Instance.Error(ELogModule.AutoPilot, ELogAuthor.CB, "TransportNetworkController.FindPath return null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.FindPathResult.RefreshData(this.TrackingData.MapId, this.ActorComp.ActorLocationProxy, targetPos, transportFindPathResult);
		}

		// Token: 0x0603274C RID: 206668 RVA: 0x00E27FDD File Offset: 0x00E261DD
		public bool CheckPlayerToTargetDistanceValid(global::Vector targetPos)
		{
			return this.ActorComp != null && global::Vector.DistSquared2D(this.ActorComp.ActorLocationProxy, targetPos) > this.PlayerToTargetDistanceThreshold;
		}

		// Token: 0x0603274D RID: 206669 RVA: 0x00E28002 File Offset: 0x00E26202
		public void RefreshCirclePath(int circleId, bool isInCircle)
		{
			if (this.CirclePathResult == null)
			{
				this.CirclePathResult = new AutoPilotCirclePathResult(circleId, isInCircle);
			}
			this.CirclePathResult.RefreshPathToCircleData();
		}

		// Token: 0x0603274E RID: 206670 RVA: 0x00E28024 File Offset: 0x00E26224
		public bool GetIsInAutoPilot()
		{
			return this.IsInAutoPilotInner;
		}

		// Token: 0x0603274F RID: 206671 RVA: 0x00E2802C File Offset: 0x00E2622C
		public AutoPilotDefine.EAutoPilotState GetAutoPilotState()
		{
			return this.AutoPilotState;
		}

		// Token: 0x06032750 RID: 206672 RVA: 0x00E28034 File Offset: 0x00E26234
		public void SetAutoPilotState(AutoPilotDefine.EAutoPilotState state)
		{
			this.AutoPilotState = state;
			bool flag = state > AutoPilotDefine.EAutoPilotState.None;
			if (this.IsInAutoPilotInner == flag)
			{
				return;
			}
			this.IsInAutoPilotInner = flag;
			CharacterActorComponent actorComp = this.ActorComp;
			Entity entity = (actorComp != null) ? actorComp.Entity : null;
			CharacterDriveVehicleComponent characterDriveVehicleComponent = (entity != null) ? entity.GetComponent<CharacterDriveVehicleComponent>() : null;
			BaseTagComponent baseTagComponent;
			if (characterDriveVehicleComponent == null)
			{
				baseTagComponent = null;
			}
			else
			{
				Entity vehicleEntity = characterDriveVehicleComponent.VehicleEntity;
				baseTagComponent = ((vehicleEntity != null) ? vehicleEntity.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (flag)
			{
				if (baseTagComponent2 != null && !baseTagComponent2.HasTag(AutoPilotDefine.autoPilotTag))
				{
					baseTagComponent2.AddTag(new int?(AutoPilotDefine.autoPilotTag));
				}
			}
			else if (baseTagComponent2 != null && baseTagComponent2.HasTag(AutoPilotDefine.autoPilotTag))
			{
				baseTagComponent2.RemoveTag(new int?(AutoPilotDefine.autoPilotTag));
			}
			AudioSystem.Instance.PostEvent(flag ? "play_ui_moto_autopilot_tips_enter" : "play_ui_moto_autopilot_tips_exit");
			InputDistributeController.Instance.RefreshInputTag();
			EventSystem.Instance.Emit<bool>(EEventName.OnAutoPilotStateChange, flag);
		}

		// Token: 0x06032751 RID: 206673 RVA: 0x00E28110 File Offset: 0x00E26310
		public bool GetIsInMovieMode()
		{
			return this.IsInMovieModeInner;
		}

		// Token: 0x06032752 RID: 206674 RVA: 0x00E28118 File Offset: 0x00E26318
		public void SetIsInMovieMode(bool value)
		{
			this.IsInMovieModeInner = value;
			InputDistributeController.Instance.RefreshInputTag();
			EventSystem.Instance.Emit<bool>(EEventName.MotorInMovieModeChange, value);
		}

		// Token: 0x06032753 RID: 206675 RVA: 0x00E2813C File Offset: 0x00E2633C
		public double GetPlayerToTargetDistanceThreshold()
		{
			return this.PlayerToTargetDistanceThreshold;
		}

		// Token: 0x06032754 RID: 206676 RVA: 0x00E28144 File Offset: 0x00E26344
		public int GetEnterMovieModeTimeThreshold()
		{
			return this.EnterMovieModeTimeThreshold;
		}

		// Token: 0x06032755 RID: 206677 RVA: 0x00E2814C File Offset: 0x00E2634C
		public double GetEnterMovieModeDistanceThreshold()
		{
			return this.EnterMovieModeDistanceThreshold;
		}

		// Token: 0x06032756 RID: 206678 RVA: 0x00E28154 File Offset: 0x00E26354
		public int GetCanSkipTimeThreshold()
		{
			return this.CanSkipTimeThreshold;
		}

		// Token: 0x06032757 RID: 206679 RVA: 0x00E2815C File Offset: 0x00E2635C
		public double GetCanSkipDistanceThreshold()
		{
			return this.CanSkipDistanceThreshold;
		}

		// Token: 0x06032758 RID: 206680 RVA: 0x00E28164 File Offset: 0x00E26364
		public int GetSkillHighLightTime()
		{
			return this.SkillHighLightTime;
		}

		// Token: 0x06032759 RID: 206681 RVA: 0x00E2816C File Offset: 0x00E2636C
		public double GetAutoPilotTime()
		{
			return this.AutoPilotTime;
		}

		// Token: 0x0603275A RID: 206682 RVA: 0x00E28174 File Offset: 0x00E26374
		public void AddAutoPilotTime(double deltaTime)
		{
			this.AutoPilotTime += deltaTime;
		}

		// Token: 0x0603275B RID: 206683 RVA: 0x00E28184 File Offset: 0x00E26384
		public void ResetAutoPilotTime()
		{
			this.AutoPilotTime = 0.0;
		}

		// Token: 0x1700624E RID: 25166
		// (get) Token: 0x0603275C RID: 206684 RVA: 0x00E28195 File Offset: 0x00E26395
		// (set) Token: 0x0603275D RID: 206685 RVA: 0x00E2819D File Offset: 0x00E2639D
		public int AutoPilotAreaId
		{
			get
			{
				return this.AutoPilotAreaIdInner;
			}
			set
			{
				if (this.AutoPilotAreaIdInner == value)
				{
					return;
				}
				if (this.TrackingData != null)
				{
					this.SetTrackingMarkItem(null);
				}
				this.AutoPilotAreaIdInner = value;
			}
		}

		// Token: 0x0603275E RID: 206686 RVA: 0x00E281BF File Offset: 0x00E263BF
		public bool GetIsCanShowSkipBtn()
		{
			return this.IsCanShowSkipBtn;
		}

		// Token: 0x0603275F RID: 206687 RVA: 0x00E281C7 File Offset: 0x00E263C7
		public void SetIsCanShowSkipBtn(bool value)
		{
			this.IsCanShowSkipBtn = value;
		}

		// Token: 0x06032760 RID: 206688 RVA: 0x00E281D0 File Offset: 0x00E263D0
		public AutoPilotDefine.IEnableAutoPilot GetEnableAutoPilot()
		{
			return this.EnableAutoPilot;
		}

		// Token: 0x06032761 RID: 206689 RVA: 0x00E281D8 File Offset: 0x00E263D8
		private void OnUnTrackMark(ITrackData markItem)
		{
			if (this.TrackingMarkItem == null)
			{
				return;
			}
			if (!TrackModel.Instance.IsTracking(this.TrackingMarkItem.TrackSource, this.TrackingMarkItem.MarkId))
			{
				this.SetTrackingMarkItem(null);
			}
		}

		// Token: 0x06032762 RID: 206690 RVA: 0x00E2820C File Offset: 0x00E2640C
		public unsafe void SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot value, AutoPilotDefine.EDisableAutoPilotReason? reason = null)
		{
			if (this.EnableAutoPilot.Value == value)
			{
				AutoPilotDefine.EDisableAutoPilotReason? disableReason = this.EnableAutoPilot.DisableReason;
				AutoPilotDefine.EDisableAutoPilotReason? edisableAutoPilotReason = reason;
				if (disableReason.GetValueOrDefault() == edisableAutoPilotReason.GetValueOrDefault() & disableReason != null == (edisableAutoPilotReason != null))
				{
					return;
				}
			}
			this.EnableAutoPilot.Value = value;
			this.EnableAutoPilot.DisableReason = reason;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AutoPilot;
			ELogAuthor author = ELogAuthor.CB;
			string message = "设置可巡航的状态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("value", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			AutoPilotController.Instance.RefreshHighLightExploreSkill();
			if (value == AutoPilotDefine.EEnableAutoPilot.Dest)
			{
				FunctionModel instance2 = FunctionModel.Instance;
				if (instance2 != null && instance2.IsOpen(EFunctionType.MotorDevelop))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId(AutoPilotDefine.EAutoPilotTextId.TextCanAutoPilot, Array.Empty<object>());
				}
			}
		}

		// Token: 0x06032763 RID: 206691 RVA: 0x00E2830C File Offset: 0x00E2650C
		public bool CheckCommonConditions()
		{
			if (this.IsInAutoPilotInner)
			{
				this.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Disable, new AutoPilotDefine.EDisableAutoPilotReason?(AutoPilotDefine.EDisableAutoPilotReason.InAutoPilot));
				return false;
			}
			CharacterActorComponent actorComp = this.ActorComp;
			int? num = (actorComp != null) ? new int?(actorComp.CreatureData.GetRoleId()) : null;
			bool flag = (num ?? 0) == 0;
			if (flag)
			{
				this.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Disable, new AutoPilotDefine.EDisableAutoPilotReason?(AutoPilotDefine.EDisableAutoPilotReason.NotValidRole));
				return false;
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num.Value, true);
			if (((roleDataById != null) ? new bool?(roleDataById.IsTrialRole()) : null).GetValueOrDefault())
			{
				this.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Disable, new AutoPilotDefine.EDisableAutoPilotReason?(AutoPilotDefine.EDisableAutoPilotReason.NotValidRole));
				return false;
			}
			return true;
		}

		// Token: 0x06032764 RID: 206692 RVA: 0x00E283C8 File Offset: 0x00E265C8
		public void CheckCircleAutoPilotConditions()
		{
			if (!this.CheckCommonConditions())
			{
				return;
			}
			AutoPilotDefine.IAutoPilotCircles autoPilotCircles;
			this.MapIdToCirclePathMap.TryGetValue(MapModel.Instance.CurrentWorldMapConfigId, out autoPilotCircles);
			if (autoPilotCircles == null)
			{
				Log.Instance.Info(ELogModule.AutoPilot, ELogAuthor.CB, "当前没有环路数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Disable, new AutoPilotDefine.EDisableAutoPilotReason?(AutoPilotDefine.EDisableAutoPilotReason.NoCirclePath));
				return;
			}
			Entity vehicleEntity = this.VehicleEntity;
			MotorcycleRoadwayComponent motorcycleRoadwayComponent = (vehicleEntity != null) ? vehicleEntity.GetComponent<MotorcycleRoadwayComponent>() : null;
			if (!((motorcycleRoadwayComponent != null) ? new bool?(motorcycleRoadwayComponent.GetIsOnNearestRoadway()) : null).GetValueOrDefault())
			{
				this.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Disable, new AutoPilotDefine.EDisableAutoPilotReason?(AutoPilotDefine.EDisableAutoPilotReason.NotNearRoad));
				return;
			}
			NearestRoadway nearestRoadway = (motorcycleRoadwayComponent != null) ? motorcycleRoadwayComponent.GetNearestRoadway() : null;
			UKuroRoadway roadway = (nearestRoadway != null) ? nearestRoadway.Roadway : null;
			if (roadway == null)
			{
				this.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Disable, new AutoPilotDefine.EDisableAutoPilotReason?(AutoPilotDefine.EDisableAutoPilotReason.NoCirclePath));
				return;
			}
			Predicate<int> <>9__0;
			foreach (int num in autoPilotCircles.CircleIds)
			{
				AutoPilotCircles? autoPilotCircles2;
				int[] array = (ConfigAutoPilotCirclesById.GetConfig(num, true) != null) ? autoPilotCircles2.GetValueOrDefault().WaySplines() : null;
				if (array != null)
				{
					int[] array2 = array;
					Predicate<int> match;
					if ((match = <>9__0) == null)
					{
						match = (<>9__0 = ((int id) => id == roadway.Id));
					}
					if (Array.Exists<int>(array2, match))
					{
						this.RefreshCirclePath(num, true);
						this.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Loop, null);
						return;
					}
				}
			}
			if (this.CheckCircleInIntersection(roadway.Id, autoPilotCircles.CircleIds))
			{
				this.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Loop, null);
				return;
			}
			if (this.CheckCanReachCircle(autoPilotCircles.CircleIds))
			{
				this.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Loop, null);
				return;
			}
			this.SetEnableAutoPilot(AutoPilotDefine.EEnableAutoPilot.Disable, new AutoPilotDefine.EDisableAutoPilotReason?(AutoPilotDefine.EDisableAutoPilotReason.NoCirclePath));
		}

		// Token: 0x06032765 RID: 206693 RVA: 0x00E285B8 File Offset: 0x00E267B8
		private bool CheckCircleInIntersection(int roadWayId, List<int> circleIds)
		{
			UKuroTransportNetworkSubsystem transportSystem = TransportNetworkController.Instance.GetTransportSystem();
			int intersectionId = transportSystem.GetIntersectionId(roadWayId);
			if (intersectionId == 0)
			{
				return false;
			}
			TArray<int> tarray = new TArray<int>();
			transportSystem.GetRoadwaysAtSameIntersection(intersectionId, ref tarray);
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				UKuroRoadway roadWay = transportSystem.GetRoadWay(tarray.Get(i));
				if (roadWay != null)
				{
					Predicate<int> <>9__0;
					foreach (int num2 in circleIds)
					{
						AutoPilotCircles? autoPilotCircles;
						int[] array = (ConfigAutoPilotCirclesById.GetConfig(num2, true) != null) ? autoPilotCircles.GetValueOrDefault().WaySplines() : null;
						if (array != null)
						{
							CharacterActorComponent actorComp = this.ActorComp;
							int[] array2 = array;
							Predicate<int> match;
							if ((match = <>9__0) == null)
							{
								match = (<>9__0 = ((int id) => id == roadWay.Id));
							}
							if (Array.Exists<int>(array2, match) && actorComp != null && AutoPilotUtil.IsNearRoadWay(roadWay, actorComp.ActorLocationProxy))
							{
								this.RefreshCirclePath(num2, true);
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06032766 RID: 206694 RVA: 0x00E28700 File Offset: 0x00E26900
		private bool CheckCanReachCircle(List<int> circleIds)
		{
			foreach (int num in circleIds)
			{
				AutoPilotCircles? autoPilotCircles;
				int[] array = (ConfigAutoPilotCirclesById.GetConfig(num, true) != null) ? autoPilotCircles.GetValueOrDefault().WaySplines() : null;
				if (array != null)
				{
					CharacterActorComponent actorComp = this.ActorComp;
					if (actorComp != null && this.CanReachCirclePath(actorComp.ActorLocationProxy, array))
					{
						this.RefreshCirclePath(num, false);
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06032767 RID: 206695 RVA: 0x00E2879C File Offset: 0x00E2699C
		private bool CanReachCirclePath(global::Vector actorLocation, int[] circlePath)
		{
			UKuroRoadway roadWay = TransportNetworkController.Instance.GetTransportSystem().GetRoadWay(circlePath[0]);
			if (roadWay == null)
			{
				return false;
			}
			USplineComponent roadSpline = roadWay.RoadSpline;
			FVectorDouble? fvectorDouble = (roadSpline != null) ? new FVectorDouble?(roadSpline.D_GetLocationAtSplinePoint(1, ESplineCoordinateSpace.World)) : null;
			if (fvectorDouble == null)
			{
				return false;
			}
			global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
			FVectorDouble? fvectorDouble2 = fvectorDouble;
			commonTempVector.DeepCopy((fvectorDouble2 != null) ? fvectorDouble2.GetValueOrDefault() : null);
			ITransportFindPathResult transportFindPathResult = TransportNetworkController.Instance.FindPath(actorLocation, MathUtils.Instance.CommonTempVector, true, false, this.IsDebugMode);
			if (transportFindPathResult == null)
			{
				return false;
			}
			int num = transportFindPathResult.Roadways.Num();
			for (int i = 0; i < num; i++)
			{
				UKuroRoadway roadway = transportFindPathResult.Roadways.Get(i);
				bool isDebugMode = this.IsDebugMode;
				if (Array.Exists<int>(circlePath, (int id) => id == roadway.Id))
				{
					this.EnterCircleRoadId = roadway.Id;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06032768 RID: 206696 RVA: 0x00E288A4 File Offset: 0x00E26AA4
		private void OnMovieMotorRideSharingModeChangeResponse(bool enable, bool success)
		{
			if (!enable)
			{
				CustomPromise<bool> exitMovieModeWithRideShareQuitPromise = this.ExitMovieModeWithRideShareQuitPromise;
				if (exitMovieModeWithRideShareQuitPromise == null)
				{
					return;
				}
				exitMovieModeWithRideShareQuitPromise.SetResult(success);
				return;
			}
			else
			{
				CustomPromise<bool> enterRideSharePromise = this.EnterRideSharePromise;
				if (enterRideSharePromise == null)
				{
					return;
				}
				enterRideSharePromise.SetResult(success);
				return;
			}
		}

		// Token: 0x06032769 RID: 206697 RVA: 0x00E288CC File Offset: 0x00E26ACC
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove<ITrackData>(EEventName.UnTrackMark, new Action<ITrackData>(this.OnUnTrackMark));
			EventSystem.Instance.Remove<bool, bool>(EEventName.OnMovieMotorRideSharingModeChangeResponse, new Action<bool, bool>(this.OnMovieMotorRideSharingModeChangeResponse));
		}

		// Token: 0x0603276A RID: 206698 RVA: 0x00E28906 File Offset: 0x00E26B06
		protected override bool OnClear()
		{
			this.ClearData();
			this.MapIdToCirclePathMap.Clear();
			this.RemoveEvents();
			this.EnterRideSharePromise = null;
			this.ExitMovieModeWithRideShareQuitPromise = null;
			this.MovieModeCameraRowNameArray.Clear();
			return true;
		}

		// Token: 0x1700624F RID: 25167
		// (get) Token: 0x0603276B RID: 206699 RVA: 0x00E28939 File Offset: 0x00E26B39
		public static AutoPilotModel Instance
		{
			get
			{
				return AutoPilotModel._Instance;
			}
		}

		// Token: 0x0603276C RID: 206700 RVA: 0x00E28940 File Offset: 0x00E26B40
		public static AutoPilotModel GetOrCreateInstance()
		{
			if (AutoPilotModel._Instance == null)
			{
				AutoPilotModel.CreateInstance();
			}
			return AutoPilotModel._Instance;
		}

		// Token: 0x0603276D RID: 206701 RVA: 0x00E28954 File Offset: 0x00E26B54
		public static bool CreateInstance()
		{
			if (AutoPilotModel._Instance != null)
			{
				return true;
			}
			AutoPilotModel._Instance = new AutoPilotModel();
			return true;
		}

		// Token: 0x0603276E RID: 206702 RVA: 0x00E2896A File Offset: 0x00E26B6A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603276F RID: 206703 RVA: 0x00E2896C File Offset: 0x00E26B6C
		public static void ResetStaticDefaultValue()
		{
			AutoPilotModel._Instance = null;
		}

		// Token: 0x06032770 RID: 206704 RVA: 0x00E28974 File Offset: 0x00E26B74
		static AutoPilotModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AutoPilotModel.CreateStaticDefaultValue), new Action(AutoPilotModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401AC21 RID: 109601
		private bool IsInAutoPilotInner;

		// Token: 0x0401AC22 RID: 109602
		private bool IsInMovieModeInner;

		// Token: 0x0401AC23 RID: 109603
		[Nullable(2)]
		private MarkItem TrackingMarkItem;

		// Token: 0x0401AC24 RID: 109604
		[Nullable(2)]
		private AutoPilotFindPathResult FindPathResult;

		// Token: 0x0401AC25 RID: 109605
		[Nullable(2)]
		private AutoPilotCirclePathResult CirclePathResult;

		// Token: 0x0401AC26 RID: 109606
		private double PlayerToTargetDistanceThreshold;

		// Token: 0x0401AC27 RID: 109607
		private double SplineDistanceThreshold;

		// Token: 0x0401AC28 RID: 109608
		private int SkillHighLightTime = -1;

		// Token: 0x0401AC29 RID: 109609
		private int EnterMovieModeTimeThreshold;

		// Token: 0x0401AC2A RID: 109610
		private double EnterMovieModeDistanceThreshold;

		// Token: 0x0401AC2B RID: 109611
		private int CanSkipTimeThreshold;

		// Token: 0x0401AC2C RID: 109612
		private double CanSkipDistanceThreshold;

		// Token: 0x0401AC2D RID: 109613
		private double AutoPilotTime;

		// Token: 0x0401AC2E RID: 109614
		[Nullable(2)]
		private AutoPilotDefine.IAutoPilotTrackingData TrackingData;

		// Token: 0x0401AC2F RID: 109615
		private bool IsCanShowSkipBtn;

		// Token: 0x0401AC30 RID: 109616
		public bool IsDebugMode;

		// Token: 0x0401AC31 RID: 109617
		public bool IsSkipConfirmBoxShow = true;

		// Token: 0x0401AC32 RID: 109618
		public readonly Dictionary<int, AutoPilotDefine.IAutoPilotCircles> MapIdToCirclePathMap = new Dictionary<int, AutoPilotDefine.IAutoPilotCircles>();

		// Token: 0x0401AC33 RID: 109619
		public int EnterCircleRoadId;

		// Token: 0x0401AC34 RID: 109620
		private readonly AutoPilotDefine.IEnableAutoPilot EnableAutoPilot = new EnableAutoPilot
		{
			Value = AutoPilotDefine.EEnableAutoPilot.Disable
		};

		// Token: 0x0401AC35 RID: 109621
		public float RideShareBtnProgress;

		// Token: 0x0401AC36 RID: 109622
		public bool HideQuickTransferConfirmBox;

		// Token: 0x0401AC37 RID: 109623
		public bool IsAllowExitByMove;

		// Token: 0x0401AC38 RID: 109624
		public List<int> DebugRoadWayIds = new List<int>();

		// Token: 0x0401AC39 RID: 109625
		public int DebugCircleId;

		// Token: 0x0401AC3A RID: 109626
		public global::Vector LastActorLocation = global::Vector.Create();

		// Token: 0x0401AC3B RID: 109627
		[Nullable(2)]
		public MotorcycleSplineMoveComponent SplineMoveComp;

		// Token: 0x0401AC3C RID: 109628
		public bool IsSummonWaitingEnterVehicle;

		// Token: 0x0401AC3D RID: 109629
		private AutoPilotDefine.EAutoPilotState AutoPilotState;

		// Token: 0x0401AC3E RID: 109630
		[Nullable(2)]
		public Entity VehicleEntity;

		// Token: 0x0401AC3F RID: 109631
		[Nullable(2)]
		public CustomPromise<bool> ExitMovieModeWithRideShareQuitPromise;

		// Token: 0x0401AC40 RID: 109632
		[Nullable(2)]
		public CustomPromise<bool> EnterRideSharePromise;

		// Token: 0x0401AC41 RID: 109633
		public double HighLightSampleDist;

		// Token: 0x0401AC42 RID: 109634
		public double AutoPilotRoadWayWidthOffset;

		// Token: 0x0401AC43 RID: 109635
		public double AutoPilotExitHorizontalDistThreshold;

		// Token: 0x0401AC44 RID: 109636
		public double AutoPilotExitVerticalDistThreshold;

		// Token: 0x0401AC45 RID: 109637
		public List<string> MovieModeCameraRowNameArray = new List<string>();

		// Token: 0x0401AC46 RID: 109638
		public double AutoPilotStuckSpeedThreshold;

		// Token: 0x0401AC47 RID: 109639
		public double AutoPilotStuckTimeThreshold;

		// Token: 0x0401AC48 RID: 109640
		public double AutoPilotStuckStepDistance;

		// Token: 0x0401AC49 RID: 109641
		private int AutoPilotAreaIdInner;

		// Token: 0x0401AC4A RID: 109642
		[Nullable(2)]
		private static AutoPilotModel _Instance;
	}
}
