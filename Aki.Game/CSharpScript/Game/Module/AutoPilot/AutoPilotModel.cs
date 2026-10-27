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
	// Token: 0x02005E70 RID: 24176
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class AutoPilotModel : ModelBase
	{
		// Token: 0x17008E7B RID: 36475
		// (get) Token: 0x0603D7AB RID: 251819 RVA: 0x00ED62FE File Offset: 0x00ED44FE
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

		// Token: 0x0603D7AC RID: 251820 RVA: 0x00ED6326 File Offset: 0x00ED4526
		protected override bool OnInit()
		{
			this.InitParameters();
			this.AddEvents();
			return true;
		}

		// Token: 0x0603D7AD RID: 251821 RVA: 0x00ED6335 File Offset: 0x00ED4535
		private void AddEvents()
		{
			EventSystem.Instance.Add<ITrackData>(EEventName.UnTrackMark, new Action<ITrackData>(this.OnUnTrackMark));
			EventSystem.Instance.Add<bool, bool>(EEventName.OnMovieMotorRideSharingModeChangeResponse, new Action<bool, bool>(this.OnMovieMotorRideSharingModeChangeResponse));
		}

		// Token: 0x0603D7AE RID: 251822 RVA: 0x00ED6370 File Offset: 0x00ED4570
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

		// Token: 0x0603D7AF RID: 251823 RVA: 0x00ED6588 File Offset: 0x00ED4788
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

		// Token: 0x0603D7B0 RID: 251824 RVA: 0x00ED6768 File Offset: 0x00ED4968
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

		// Token: 0x0603D7B1 RID: 251825 RVA: 0x00ED67AB File Offset: 0x00ED49AB
		public bool GetIsTracking(int markId)
		{
			MarkItem trackingMarkItem = this.TrackingMarkItem;
			return trackingMarkItem != null && trackingMarkItem.MarkId == markId;
		}

		// Token: 0x0603D7B2 RID: 251826 RVA: 0x00ED67C4 File Offset: 0x00ED49C4
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

		// Token: 0x0603D7B3 RID: 251827 RVA: 0x00ED687E File Offset: 0x00ED4A7E
		public void ClearData()
		{
			this.ClearTrackingData();
			this.ClearCirclePathResult();
		}

		// Token: 0x0603D7B4 RID: 251828 RVA: 0x00ED688C File Offset: 0x00ED4A8C
		public void ClearFindPathResult()
		{
			AutoPilotFindPathResult findPathResult = this.FindPathResult;
			if (findPathResult != null)
			{
				findPathResult.Clear();
			}
			this.FindPathResult = null;
		}

		// Token: 0x0603D7B5 RID: 251829 RVA: 0x00ED68A6 File Offset: 0x00ED4AA6
		public void ClearCirclePathResult()
		{
			this.CirclePathResult = null;
		}

		// Token: 0x0603D7B6 RID: 251830 RVA: 0x00ED68B0 File Offset: 0x00ED4AB0
		public void SetTrackingData(AutoPilotDefine.IAutoPilotTrackingData trackingData)
		{
			this.TrackingData = trackingData;
			this.RefreshFindPath(null);
			EventSystem.Instance.Emit(EEventName.OnUpdateAutoPilotLine);
			AutoPilotController.Instance.AddTick(new Action<float?>(this.RefreshFindPath));
		}

		// Token: 0x0603D7B7 RID: 251831 RVA: 0x00ED68FC File Offset: 0x00ED4AFC
		public void ClearTrackingData()
		{
			AutoPilotController.Instance.ExitAutoPilot("ClearTrackingData", false);
			this.TrackingData = null;
			this.ClearFindPathResult();
			EventSystem.Instance.Emit(EEventName.OnUpdateAutoPilotLine);
			AutoPilotController.Instance.RemoveTick(new Action<float?>(this.RefreshFindPath));
		}

		// Token: 0x0603D7B8 RID: 251832 RVA: 0x00ED694D File Offset: 0x00ED4B4D
		public double GetSplineDistanceThreshold()
		{
			return this.SplineDistanceThreshold;
		}

		// Token: 0x0603D7B9 RID: 251833 RVA: 0x00ED6955 File Offset: 0x00ED4B55
		[NullableContext(2)]
		public AutoPilotFindPathResult GetFindPathResult()
		{
			return this.FindPathResult;
		}

		// Token: 0x0603D7BA RID: 251834 RVA: 0x00ED695D File Offset: 0x00ED4B5D
		[NullableContext(2)]
		public AutoPilotCirclePathResult GetCirclePathResult()
		{
			return this.CirclePathResult;
		}

		// Token: 0x0603D7BB RID: 251835 RVA: 0x00ED6968 File Offset: 0x00ED4B68
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

		// Token: 0x0603D7BC RID: 251836 RVA: 0x00ED6A65 File Offset: 0x00ED4C65
		public bool CheckPlayerToTargetDistanceValid(global::Vector targetPos)
		{
			return this.ActorComp != null && global::Vector.DistSquared2D(this.ActorComp.ActorLocationProxy, targetPos) > this.PlayerToTargetDistanceThreshold;
		}

		// Token: 0x0603D7BD RID: 251837 RVA: 0x00ED6A8A File Offset: 0x00ED4C8A
		public void RefreshCirclePath(int circleId, bool isInCircle)
		{
			if (this.CirclePathResult == null)
			{
				this.CirclePathResult = new AutoPilotCirclePathResult(circleId, isInCircle);
			}
			this.CirclePathResult.RefreshPathToCircleData();
		}

		// Token: 0x0603D7BE RID: 251838 RVA: 0x00ED6AAC File Offset: 0x00ED4CAC
		public bool GetIsInAutoPilot()
		{
			return this.IsInAutoPilotInner;
		}

		// Token: 0x0603D7BF RID: 251839 RVA: 0x00ED6AB4 File Offset: 0x00ED4CB4
		public AutoPilotDefine.EAutoPilotState GetAutoPilotState()
		{
			return this.AutoPilotState;
		}

		// Token: 0x0603D7C0 RID: 251840 RVA: 0x00ED6ABC File Offset: 0x00ED4CBC
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

		// Token: 0x0603D7C1 RID: 251841 RVA: 0x00ED6B98 File Offset: 0x00ED4D98
		public bool GetIsInMovieMode()
		{
			return this.IsInMovieModeInner;
		}

		// Token: 0x0603D7C2 RID: 251842 RVA: 0x00ED6BA0 File Offset: 0x00ED4DA0
		public void SetIsInMovieMode(bool value)
		{
			this.IsInMovieModeInner = value;
			InputDistributeController.Instance.RefreshInputTag();
			EventSystem.Instance.Emit<bool>(EEventName.MotorInMovieModeChange, value);
		}

		// Token: 0x0603D7C3 RID: 251843 RVA: 0x00ED6BC4 File Offset: 0x00ED4DC4
		public double GetPlayerToTargetDistanceThreshold()
		{
			return this.PlayerToTargetDistanceThreshold;
		}

		// Token: 0x0603D7C4 RID: 251844 RVA: 0x00ED6BCC File Offset: 0x00ED4DCC
		public int GetEnterMovieModeTimeThreshold()
		{
			return this.EnterMovieModeTimeThreshold;
		}

		// Token: 0x0603D7C5 RID: 251845 RVA: 0x00ED6BD4 File Offset: 0x00ED4DD4
		public double GetEnterMovieModeDistanceThreshold()
		{
			return this.EnterMovieModeDistanceThreshold;
		}

		// Token: 0x0603D7C6 RID: 251846 RVA: 0x00ED6BDC File Offset: 0x00ED4DDC
		public int GetCanSkipTimeThreshold()
		{
			return this.CanSkipTimeThreshold;
		}

		// Token: 0x0603D7C7 RID: 251847 RVA: 0x00ED6BE4 File Offset: 0x00ED4DE4
		public double GetCanSkipDistanceThreshold()
		{
			return this.CanSkipDistanceThreshold;
		}

		// Token: 0x0603D7C8 RID: 251848 RVA: 0x00ED6BEC File Offset: 0x00ED4DEC
		public int GetSkillHighLightTime()
		{
			return this.SkillHighLightTime;
		}

		// Token: 0x0603D7C9 RID: 251849 RVA: 0x00ED6BF4 File Offset: 0x00ED4DF4
		public double GetAutoPilotTime()
		{
			return this.AutoPilotTime;
		}

		// Token: 0x0603D7CA RID: 251850 RVA: 0x00ED6BFC File Offset: 0x00ED4DFC
		public void AddAutoPilotTime(double deltaTime)
		{
			this.AutoPilotTime += deltaTime;
		}

		// Token: 0x0603D7CB RID: 251851 RVA: 0x00ED6C0C File Offset: 0x00ED4E0C
		public void ResetAutoPilotTime()
		{
			this.AutoPilotTime = 0.0;
		}

		// Token: 0x17008E7C RID: 36476
		// (get) Token: 0x0603D7CC RID: 251852 RVA: 0x00ED6C1D File Offset: 0x00ED4E1D
		// (set) Token: 0x0603D7CD RID: 251853 RVA: 0x00ED6C25 File Offset: 0x00ED4E25
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

		// Token: 0x0603D7CE RID: 251854 RVA: 0x00ED6C47 File Offset: 0x00ED4E47
		public bool GetIsCanShowSkipBtn()
		{
			return this.IsCanShowSkipBtn;
		}

		// Token: 0x0603D7CF RID: 251855 RVA: 0x00ED6C4F File Offset: 0x00ED4E4F
		public void SetIsCanShowSkipBtn(bool value)
		{
			this.IsCanShowSkipBtn = value;
		}

		// Token: 0x0603D7D0 RID: 251856 RVA: 0x00ED6C58 File Offset: 0x00ED4E58
		public AutoPilotDefine.IEnableAutoPilot GetEnableAutoPilot()
		{
			return this.EnableAutoPilot;
		}

		// Token: 0x0603D7D1 RID: 251857 RVA: 0x00ED6C60 File Offset: 0x00ED4E60
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

		// Token: 0x0603D7D2 RID: 251858 RVA: 0x00ED6C94 File Offset: 0x00ED4E94
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

		// Token: 0x0603D7D3 RID: 251859 RVA: 0x00ED6D94 File Offset: 0x00ED4F94
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

		// Token: 0x0603D7D4 RID: 251860 RVA: 0x00ED6E50 File Offset: 0x00ED5050
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

		// Token: 0x0603D7D5 RID: 251861 RVA: 0x00ED7040 File Offset: 0x00ED5240
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

		// Token: 0x0603D7D6 RID: 251862 RVA: 0x00ED7188 File Offset: 0x00ED5388
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

		// Token: 0x0603D7D7 RID: 251863 RVA: 0x00ED7224 File Offset: 0x00ED5424
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
			MathUtils.Instance.CommonTempVector.DeepCopy(fvectorDouble);
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

		// Token: 0x0603D7D8 RID: 251864 RVA: 0x00ED7317 File Offset: 0x00ED5517
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

		// Token: 0x0603D7D9 RID: 251865 RVA: 0x00ED733F File Offset: 0x00ED553F
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove<ITrackData>(EEventName.UnTrackMark, new Action<ITrackData>(this.OnUnTrackMark));
			EventSystem.Instance.Remove<bool, bool>(EEventName.OnMovieMotorRideSharingModeChangeResponse, new Action<bool, bool>(this.OnMovieMotorRideSharingModeChangeResponse));
		}

		// Token: 0x0603D7DA RID: 251866 RVA: 0x00ED7379 File Offset: 0x00ED5579
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

		// Token: 0x17008E7D RID: 36477
		// (get) Token: 0x0603D7DB RID: 251867 RVA: 0x00ED73AC File Offset: 0x00ED55AC
		public static AutoPilotModel Instance
		{
			get
			{
				return AutoPilotModel._Instance;
			}
		}

		// Token: 0x0603D7DC RID: 251868 RVA: 0x00ED73B3 File Offset: 0x00ED55B3
		public static AutoPilotModel GetOrCreateInstance()
		{
			if (AutoPilotModel._Instance == null)
			{
				AutoPilotModel.CreateInstance();
			}
			return AutoPilotModel._Instance;
		}

		// Token: 0x0603D7DD RID: 251869 RVA: 0x00ED73C7 File Offset: 0x00ED55C7
		public static bool CreateInstance()
		{
			if (AutoPilotModel._Instance != null)
			{
				return true;
			}
			AutoPilotModel._Instance = new AutoPilotModel();
			return true;
		}

		// Token: 0x0603D7DE RID: 251870 RVA: 0x00ED73DD File Offset: 0x00ED55DD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D7DF RID: 251871 RVA: 0x00ED73DF File Offset: 0x00ED55DF
		public static void ResetStaticDefaultValue()
		{
			AutoPilotModel._Instance = null;
		}

		// Token: 0x0603D7E0 RID: 251872 RVA: 0x00ED73E7 File Offset: 0x00ED55E7
		static AutoPilotModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AutoPilotModel.CreateStaticDefaultValue), new Action(AutoPilotModel.ResetStaticDefaultValue));
		}

		// Token: 0x0402015A RID: 131418
		private bool IsInAutoPilotInner;

		// Token: 0x0402015B RID: 131419
		private bool IsInMovieModeInner;

		// Token: 0x0402015C RID: 131420
		[Nullable(2)]
		private MarkItem TrackingMarkItem;

		// Token: 0x0402015D RID: 131421
		[Nullable(2)]
		private AutoPilotFindPathResult FindPathResult;

		// Token: 0x0402015E RID: 131422
		[Nullable(2)]
		private AutoPilotCirclePathResult CirclePathResult;

		// Token: 0x0402015F RID: 131423
		private double PlayerToTargetDistanceThreshold;

		// Token: 0x04020160 RID: 131424
		private double SplineDistanceThreshold;

		// Token: 0x04020161 RID: 131425
		private int SkillHighLightTime = -1;

		// Token: 0x04020162 RID: 131426
		private int EnterMovieModeTimeThreshold;

		// Token: 0x04020163 RID: 131427
		private double EnterMovieModeDistanceThreshold;

		// Token: 0x04020164 RID: 131428
		private int CanSkipTimeThreshold;

		// Token: 0x04020165 RID: 131429
		private double CanSkipDistanceThreshold;

		// Token: 0x04020166 RID: 131430
		private double AutoPilotTime;

		// Token: 0x04020167 RID: 131431
		[Nullable(2)]
		private AutoPilotDefine.IAutoPilotTrackingData TrackingData;

		// Token: 0x04020168 RID: 131432
		private bool IsCanShowSkipBtn;

		// Token: 0x04020169 RID: 131433
		public bool IsDebugMode;

		// Token: 0x0402016A RID: 131434
		public bool IsSkipConfirmBoxShow = true;

		// Token: 0x0402016B RID: 131435
		public readonly Dictionary<int, AutoPilotDefine.IAutoPilotCircles> MapIdToCirclePathMap = new Dictionary<int, AutoPilotDefine.IAutoPilotCircles>();

		// Token: 0x0402016C RID: 131436
		public int EnterCircleRoadId;

		// Token: 0x0402016D RID: 131437
		private readonly AutoPilotDefine.IEnableAutoPilot EnableAutoPilot = new EnableAutoPilot
		{
			Value = AutoPilotDefine.EEnableAutoPilot.Disable
		};

		// Token: 0x0402016E RID: 131438
		public float RideShareBtnProgress;

		// Token: 0x0402016F RID: 131439
		public bool HideQuickTransferConfirmBox;

		// Token: 0x04020170 RID: 131440
		public bool IsAllowExitByMove;

		// Token: 0x04020171 RID: 131441
		public List<int> DebugRoadWayIds = new List<int>();

		// Token: 0x04020172 RID: 131442
		public int DebugCircleId;

		// Token: 0x04020173 RID: 131443
		public global::Vector LastActorLocation = global::Vector.Create();

		// Token: 0x04020174 RID: 131444
		[Nullable(2)]
		public MotorcycleSplineMoveComponent SplineMoveComp;

		// Token: 0x04020175 RID: 131445
		public bool IsSummonWaitingEnterVehicle;

		// Token: 0x04020176 RID: 131446
		private AutoPilotDefine.EAutoPilotState AutoPilotState;

		// Token: 0x04020177 RID: 131447
		[Nullable(2)]
		public Entity VehicleEntity;

		// Token: 0x04020178 RID: 131448
		[Nullable(2)]
		public CustomPromise<bool> ExitMovieModeWithRideShareQuitPromise;

		// Token: 0x04020179 RID: 131449
		[Nullable(2)]
		public CustomPromise<bool> EnterRideSharePromise;

		// Token: 0x0402017A RID: 131450
		public double HighLightSampleDist;

		// Token: 0x0402017B RID: 131451
		public double AutoPilotRoadWayWidthOffset;

		// Token: 0x0402017C RID: 131452
		public double AutoPilotExitHorizontalDistThreshold;

		// Token: 0x0402017D RID: 131453
		public double AutoPilotExitVerticalDistThreshold;

		// Token: 0x0402017E RID: 131454
		public List<string> MovieModeCameraRowNameArray = new List<string>();

		// Token: 0x0402017F RID: 131455
		public double AutoPilotStuckSpeedThreshold;

		// Token: 0x04020180 RID: 131456
		public double AutoPilotStuckTimeThreshold;

		// Token: 0x04020181 RID: 131457
		public double AutoPilotStuckStepDistance;

		// Token: 0x04020182 RID: 131458
		private int AutoPilotAreaIdInner;

		// Token: 0x04020183 RID: 131459
		[Nullable(2)]
		private static AutoPilotModel _Instance;
	}
}
