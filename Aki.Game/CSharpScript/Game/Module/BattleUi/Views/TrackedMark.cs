using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E2B RID: 20011
	[NullableContext(1)]
	[Nullable(0)]
	public class TrackedMark : UiPanelBase
	{
		// Token: 0x06032569 RID: 206185 RVA: 0x00E1CAEC File Offset: 0x00E1ACEC
		public TrackedMark(ITrackData TrackData)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			this.TrackSource = TrackData.TrackSource;
			this.IconPath = TrackData.IconPath;
			this.ShowGroupId = TrackData.ShowGroupId;
			this.MarkId = TrackData.Id;
			this.MarkType = TrackData.MarkType.GetValueOrDefault();
			this.IsWeakTrackExpress = TrackData.WeakTrack.GetValueOrDefault();
			if (TrackData.TaskMarkConfigId != null)
			{
				TaskMark? taskMarkConfig = MapConfig.Instance.GetTaskMarkConfig(TrackData.TaskMarkConfigId.Value);
				if (taskMarkConfig != null)
				{
					TaskMark valueOrDefault = taskMarkConfig.GetValueOrDefault();
					this.IsNewTrackExpress = true;
					this.MarkRingPic = valueOrDefault.MarkRingPic;
					this.MarkIconPic = valueOrDefault.MarkIcon;
					this.MarkRingColor = valueOrDefault.RingColor;
					this.SmallHaloColor = valueOrDefault.SmallHaloColor;
					this.LargeHaloColor = valueOrDefault.LargeHaloColor;
					this.IsNewTrackExpress = (!string.IsNullOrEmpty(this.MarkRingPic) || !string.IsNullOrEmpty(this.MarkIconPic) || !string.IsNullOrEmpty(this.SmallHaloColor) || !string.IsNullOrEmpty(this.LargeHaloColor));
				}
			}
			QuestMarkCreateInfo questMarkCreateInfo = MapModel.Instance.GetDynamicMark(this.MarkId) as QuestMarkCreateInfo;
			if (questMarkCreateInfo != null)
			{
				this.TaskTrackedMarkItem = new TaskTrackedMarkItem(questMarkCreateInfo, this.TrackSource);
			}
			float? trackAutoCancelDistance = TrackData.TrackAutoCancelDistance;
			float num = (float)-1;
			if (!(trackAutoCancelDistance.GetValueOrDefault() == num & trackAutoCancelDistance != null) && TrackData.TrackAutoCancelDistance != null)
			{
				this.TrackAutoCancelDistance = new float?(TrackData.TrackAutoCancelDistance.Value * 0.01f);
			}
			this.AlreadyCancelTrack = false;
			this.MarkHideDis = TrackData.TrackHideDis;
			this.TrackTarget = TrackData.TrackTarget;
			this.TrackInstanceId = (TrackData.TrackInstanceId ?? GameModeModel.Instance.InstanceDungeon.Value.Id);
			this.IsInTrackRange = TrackData.IsInTrackRange.GetValueOrDefault();
			this.AutoHide = TrackData.AutoHideTrack.GetValueOrDefault();
			this.ConfigShowTime = (float)ConfigCommonParamById.GetIntConfig("QuestMarkTrackStayTime").GetValueOrDefault(10);
			this.Offset = (TrackData.Offset ?? global::Vector.Create());
			this.NiagaraDuration = 0f;
			this.CurNiagaraShowTime = 0f;
			this.NiagaraNeedActivateNextTick = false;
			this.IsSubTrack = TrackData.IsSubTrack.GetValueOrDefault();
			this.TrackType = TrackData.TrackType.GetValueOrDefault();
			if (this.TrackType == ETrackType.AudioHint)
			{
				this.IsForceHideDistance = true;
				this.IsForceHideDirection = true;
				this.IsForceNotPlayStartSeq = true;
				this.IsForceHideIcon = true;
				EntityHandle entityById = CreatureModel.Instance.GetEntityById(this.MarkId);
				SceneItemNearbyTrackingComponent sceneItemNearbyTrackingComponent;
				if (entityById == null)
				{
					sceneItemNearbyTrackingComponent = null;
				}
				else
				{
					WorldEntity entity = entityById.Entity;
					sceneItemNearbyTrackingComponent = ((entity != null) ? entity.GetComponent<SceneItemNearbyTrackingComponent>() : null);
				}
				SceneItemNearbyTrackingComponent sceneItemNearbyTrackingComponent2 = sceneItemNearbyTrackingComponent;
				this.AudioNearRadius = (double)((float)((sceneItemNearbyTrackingComponent2 != null) ? sceneItemNearbyTrackingComponent2.AudioPointNearRadius : null).GetValueOrDefault() * 0.01f);
				this.AudioMiddleRadius = (double)((float)((sceneItemNearbyTrackingComponent2 != null) ? sceneItemNearbyTrackingComponent2.AudioPointMiddleRadius : null).GetValueOrDefault() * 0.01f);
				this.AudioFarRadius = (double)((float)((sceneItemNearbyTrackingComponent2 != null) ? sceneItemNearbyTrackingComponent2.AudioPointFarRadius : null).GetValueOrDefault() * 0.01f);
			}
			else
			{
				this.IsForceHideDistance = false;
				this.IsForceHideDirection = false;
				this.IsForceNotPlayStartSeq = false;
				this.IsForceHideIcon = false;
			}
			this.TempTrackPosition = global::Vector.Create();
			this.ScreenPosition = Vector2D.Create();
			this.LastScreenPosition = Vector2D.Create();
			this.TempRotator = global::Rotator.Create();
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			this.LimitA = Math.Min(1176f, (((uiRootItem != null) ? uiRootItem.GetWidth() : 0f) - 1008f) / 2f);
			this.LimitB = Math.Min(712.5f, (((uiRootItem != null) ? uiRootItem.GetHeight() : 0f) - 495f) / 2f);
			EventSystem.Instance.Add<ETrackSource, long, int, int, bool>(EEventName.TaskRangeTrackStateChange, new Action<ETrackSource, long, int, int, bool>(this.OnTaskRangeTrackStateChange));
		}

		// Token: 0x0603256A RID: 206186 RVA: 0x00E1CFBC File Offset: 0x00E1B1BC
		public virtual void Initialize(UUIItem parent)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_TrackedMarkMain", parent, true).Forget();
		}

		// Token: 0x0603256B RID: 206187 RVA: 0x00E1CFD0 File Offset: 0x00E1B1D0
		public void CreateMark()
		{
			this.FirstStartSequencePlaying = true;
			this.PlayTrackStartSequence(0f);
		}

		// Token: 0x0603256C RID: 206188 RVA: 0x00E1CFE4 File Offset: 0x00E1B1E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedTrackedButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603256D RID: 206189 RVA: 0x00E1D240 File Offset: 0x00E1B440
		protected override void OnStart()
		{
			this.DistanceComp = base.GetItem(4);
			this.DirectionComp = base.GetItem(2);
			this.IconComp = base.GetItem(6);
			this.DistanceComp.SetUIActive(false);
			this.DirectionComp.SetUIActive(!this.IsInTrackRange && !this.IsForceHideDirection);
			this.IconComp.SetUIActive(false);
			UUISprite sprite = base.GetSprite(7);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(10);
			UUISprite sprite3 = base.GetSprite(8);
			UUISprite sprite4 = base.GetSprite(9);
			UUIItem item = base.GetItem(11);
			if (this.IsNewTrackExpress)
			{
				bool flag = string.IsNullOrEmpty(this.MarkRingPic);
				sprite2.SetUIActive(!flag);
				item.SetUIActive(!flag);
				if (!flag)
				{
					this.SetSpriteByPath(this.MarkRingPic, sprite2, false, null, null);
				}
				if (!string.IsNullOrEmpty(this.MarkRingColor))
				{
					FColor color = FColor.FromHex(this.MarkRingColor);
					sprite2.SetColor(color);
					item.SetColor(color);
				}
				bool flag2 = string.IsNullOrEmpty(this.LargeHaloColor);
				sprite3.SetUIActive(!flag2);
				if (!flag2)
				{
					sprite3.SetColor(FColor.FromHex(this.LargeHaloColor));
				}
				bool flag3 = string.IsNullOrEmpty(this.SmallHaloColor);
				sprite4.SetUIActive(!flag3);
				if (!flag3)
				{
					sprite4.SetColor(FColor.FromHex(this.SmallHaloColor));
				}
			}
			else
			{
				sprite3.SetUIActive(false);
				sprite4.SetUIActive(false);
				sprite2.SetUIActive(false);
				item.SetUIActive(false);
			}
			this.IconTextureLevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.IconTextureLevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceEvent), false);
			this.WaveNiagara = base.GetUiNiagara(5);
			this.WaveNiagara.SetUIActive(false);
			this.UpdateIcon(true);
			this.IconComp.SetUIActive(!this.IsInTrackRange && !this.IsForceHideIcon);
			if (this.TrackSource == ETrackSource.Quest)
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem != null)
				{
					rootItem.SetHierarchyIndex(999);
				}
			}
			this.CreateMark();
			this.OnUiShow();
		}

		// Token: 0x0603256E RID: 206190 RVA: 0x00E1D464 File Offset: 0x00E1B664
		protected override void OnBeforeDestroy()
		{
			this.TrackTarget = null;
			this.TaskTrackedMarkItem = null;
			LevelSequencePlayer iconTextureLevelSequencePlayer = this.IconTextureLevelSequencePlayer;
			if (iconTextureLevelSequencePlayer != null)
			{
				iconTextureLevelSequencePlayer.Clear();
			}
			this.IconTextureLevelSequencePlayer = null;
			if (TimerSystem.Instance.Has(this.DelayTrackSequenceTimerId))
			{
				TimerSystem.Instance.Remove(this.DelayTrackSequenceTimerId);
			}
			if (EventSystem.Instance.Has(EEventName.TaskRangeTrackStateChange, new Action<ETrackSource, long, int, int, bool>(this.OnTaskRangeTrackStateChange)))
			{
				EventSystem.Instance.Remove(EEventName.TaskRangeTrackStateChange, new Action<ETrackSource, long, int, int, bool>(this.OnTaskRangeTrackStateChange));
			}
			if (EventSystem.Instance.Has(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnOnLogicTreeNodeStatusChange)))
			{
				EventSystem.Instance.Remove(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnOnLogicTreeNodeStatusChange));
			}
			if (EventSystem.Instance.Has(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnQuestTrackUpdate)))
			{
				EventSystem.Instance.Remove(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnQuestTrackUpdate));
			}
		}

		// Token: 0x0603256F RID: 206191 RVA: 0x00E1D568 File Offset: 0x00E1B768
		public virtual void OnUiShow()
		{
			if (this.TrackType == ETrackType.AudioHint)
			{
				EntityHandle entityById = CreatureModel.Instance.GetEntityById(this.MarkId);
				if (entityById != null && !EventSystem.Instance.HasWithTarget(entityById.Entity, EEventName.PlaySoundTrackEffect, new Action<float>(this.OnPlaySoundTrackEffect)))
				{
					EventSystem.Instance.AddWithTarget(entityById.Entity, EEventName.PlaySoundTrackEffect, new Action<float>(this.OnPlaySoundTrackEffect));
				}
			}
			this.DelayTrackSequenceTimerId = TimerSystem.Instance.Delay(new TTimerAction(this.PlayTrackStartSequence), 500f, null, null, true, 1f);
			if (!EventSystem.Instance.Has(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnOnLogicTreeNodeStatusChange)))
			{
				EventSystem.Instance.Add<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnOnLogicTreeNodeStatusChange));
			}
			if (!EventSystem.Instance.Has(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnQuestTrackUpdate)))
			{
				EventSystem.Instance.Add<BtType, long?>(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnQuestTrackUpdate));
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetRelativeScale3D(this.IsSubTrack ? new FVector(0.8f, 0.8f, 0.8f) : new FVector(1f, 1f, 1f));
			}
			this.UpdateUpStateSprite();
			this.UpdateDownStateSprite();
			this.UpdateGravity();
		}

		// Token: 0x06032570 RID: 206192 RVA: 0x00E1D6C8 File Offset: 0x00E1B8C8
		public virtual void OnUiHide()
		{
			if (this.TrackType == ETrackType.AudioHint)
			{
				EntityHandle entityById = CreatureModel.Instance.GetEntityById(this.MarkId);
				if (entityById != null && EventSystem.Instance.HasWithTarget(entityById.Entity, EEventName.PlaySoundTrackEffect, new Action<float>(this.OnPlaySoundTrackEffect)))
				{
					EventSystem.Instance.RemoveWithTarget(entityById.Entity, EEventName.PlaySoundTrackEffect, new Action<float>(this.OnPlaySoundTrackEffect));
				}
			}
			if (EventSystem.Instance.Has(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnOnLogicTreeNodeStatusChange)))
			{
				EventSystem.Instance.Remove(EEventName.OnLogicTreeNodeStatusChange, new Action<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.OnOnLogicTreeNodeStatusChange));
			}
			if (EventSystem.Instance.Has(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnQuestTrackUpdate)))
			{
				EventSystem.Instance.Remove(EEventName.OnLogicTreeTrackUpdate, new Action<BtType, long?>(this.OnQuestTrackUpdate));
			}
		}

		// Token: 0x06032571 RID: 206193 RVA: 0x00E1D7AC File Offset: 0x00E1B9AC
		private void OnClickedTrackedButton()
		{
			if (TrackModel.Instance.IsForceCloseTracked())
			{
				return;
			}
			global::Vector trackPositionByTrackTarget = MapUtil.GetTrackPositionByTrackTarget(this.TrackTarget, true, null, null, true);
			if (trackPositionByTrackTarget == null)
			{
				return;
			}
			BattleUiControl.Instance.FocusToTargetLocation(trackPositionByTrackTarget);
		}

		// Token: 0x06032572 RID: 206194 RVA: 0x00E1D7ED File Offset: 0x00E1B9ED
		private void SequenceEvent(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				this.FirstStartSequencePlaying = false;
				return;
			}
			if (sequenceName == "Close")
			{
				UUIItem rootItem = this.RootItem;
				if (rootItem == null)
				{
					return;
				}
				rootItem.SetUIActive(false);
			}
		}

		// Token: 0x06032573 RID: 206195 RVA: 0x00E1D822 File Offset: 0x00E1BA22
		public void UpdateTrackTarget(in TTrackTarget trackTarget)
		{
			this.TrackTarget = trackTarget;
		}

		// Token: 0x06032574 RID: 206196 RVA: 0x00E1D82C File Offset: 0x00E1BA2C
		private void UpdateIcon(bool force = false)
		{
			string text = (this.IsNewTrackExpress && !string.IsNullOrEmpty(this.MarkIconPic)) ? this.MarkIconPic : this.IconPath;
			bool flag = force || text != this.IconPath;
			this.IconPath = text;
			if (flag && !string.IsNullOrEmpty(this.IconPath))
			{
				this.SetSpriteByPath(this.IconPath, base.GetSprite(0), false, null, null);
			}
		}

		// Token: 0x06032575 RID: 206197 RVA: 0x00E1D8A4 File Offset: 0x00E1BAA4
		public void UpdateUpStateSprite()
		{
			UUISprite sprite = base.GetSprite(14);
			bool flag = MapModel.Instance.GetMarkExtraShowState(this.MarkId).ShowFlag == MapMarkShowFlag.ShowDisable;
			InstanceDungeon? instanceDungeon;
			int? num = (GameModeModel.Instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().MapConfigId) : null;
			int? relativeId = this.GetRelativeId();
			int? relativeDungeonId = this.GetRelativeDungeonId();
			bool flag2 = false;
			if (num != null)
			{
				TTrackTarget_Int ttrackTarget_Int = this.TrackTarget as TTrackTarget_Int;
				if (ttrackTarget_Int != null)
				{
					flag2 = MapModel.Instance.IsMarkHideByServer(num.Value, ttrackTarget_Int.Value);
				}
			}
			if (relativeId != null && relativeDungeonId != null)
			{
				flag2 |= LevelPlayReportModel.Instance.IsCommonLevelPlayHide(relativeDungeonId.Value, relativeId.Value);
			}
			bool isDisable = flag || flag2;
			bool isGameplayFinish = this.MarkType == EMarkType.CommonGamePlay && MarkItemDataUtil.IsCommonGamePlayMarkComplete(this.MarkId);
			string markTopRightIconPath = MarkItemDataUtil.GetMarkTopRightIconPath(this.MarkId, this.MarkType, isDisable, isGameplayFinish);
			if (!string.IsNullOrEmpty(markTopRightIconPath))
			{
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
				if (sprite != null)
				{
					this.SetSpriteByPath(markTopRightIconPath, sprite, false, null, null);
					return;
				}
			}
			else if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
		}

		// Token: 0x06032576 RID: 206198 RVA: 0x00E1D9EC File Offset: 0x00E1BBEC
		private int? GetRelativeId()
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(this.MarkId);
			if (configMark != null)
			{
				return new int?(configMark.Value.RelativeId);
			}
			return null;
		}

		// Token: 0x06032577 RID: 206199 RVA: 0x00E1DA34 File Offset: 0x00E1BC34
		private int? GetRelativeDungeonId()
		{
			MapMark? configMark = MapConfig.Instance.GetConfigMark(this.MarkId);
			if (configMark != null)
			{
				return new int?(configMark.Value.RelativeDungeonId);
			}
			return null;
		}

		// Token: 0x06032578 RID: 206200 RVA: 0x00E1DA7C File Offset: 0x00E1BC7C
		public void UpdateDownStateSprite()
		{
			UUISprite sprite = base.GetSprite(13);
			MapMark? configMark = MapConfig.Instance.GetConfigMark(this.MarkId);
			bool flag = false;
			int[] array = ((configMark != null) ? configMark.GetValueOrDefault().GetConnetMultiMapFloorIdArray() : null) ?? Array.Empty<int>();
			bool flag2 = configMark != null && configMark.GetValueOrDefault().MultiMapFloorId == 0 && array.Length != 0;
			int num = 0;
			if (configMark != null)
			{
				if (configMark.Value.MultiMapFloorId == 0 && array.Length != 0)
				{
					num = array[0];
				}
				else
				{
					num = configMark.Value.MultiMapFloorId;
				}
			}
			bool flag3 = false;
			if (num != 0 || flag2)
			{
				flag = true;
				int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
				MultiMap? subMapConfigById = MapConfig.Instance.GetSubMapConfigById(num);
				if (subMapConfigById != null && Array.IndexOf<int>(subMapConfigById.Value.GetAreaArray(), currentAreaId) >= 0)
				{
					flag3 = true;
				}
			}
			if (!flag)
			{
				if (sprite != null)
				{
					sprite.SetUIActive(false);
					return;
				}
			}
			else
			{
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(flag3 ? "SP_MarkMultiMapSelect" : "SP_MarkMultiMap");
				if (sprite != null)
				{
					this.SetSpriteByPath(resourcePath, sprite, false, null, null);
				}
			}
		}

		// Token: 0x06032579 RID: 206201 RVA: 0x00E1DBD8 File Offset: 0x00E1BDD8
		public void UpdateGravity()
		{
			InstanceDungeon? instanceDungeon;
			int? num = (GameModeModel.Instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().MapConfigId) : null;
			UUISprite sprite = base.GetSprite(7);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			if (num == null)
			{
				return;
			}
			if (!WorldMapModel.Instance.IsGravityMap(num.Value))
			{
				return;
			}
			EMapGravityDirection markMapGravity = MapModel.Instance.GetMarkMapGravity(this.MarkId, this.MarkType);
			if (markMapGravity == EMapGravityDirection.All)
			{
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath((markMapGravity == EMapGravityDirection.Down) ? "SP_OverviewDown" : "SP_OverviewUp");
			bool flag = MapModel.Instance.CurrentPlayerGravity == markMapGravity;
			if (sprite != null)
			{
				sprite.SetUIActive(true);
				this.SetSpriteByPath(resourcePath, sprite, false, null, null);
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAlpha(flag ? 1f : 0.4f);
		}

		// Token: 0x0603257A RID: 206202 RVA: 0x00E1DCCF File Offset: 0x00E1BECF
		public void SetVisibleByOccupied(bool bOccupied)
		{
			this.IsOccupied = bOccupied;
		}

		// Token: 0x0603257B RID: 206203 RVA: 0x00E1DCD8 File Offset: 0x00E1BED8
		public void SetVisibleByInteractionSpotOccupied(bool bOccupied)
		{
			this.IsOccupiedByInteractionSpot = bOccupied;
		}

		// Token: 0x0603257C RID: 206204 RVA: 0x00E1DCE4 File Offset: 0x00E1BEE4
		public void UpdateTrackDistance()
		{
			global::Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
			if (playerLocation == null)
			{
				return;
			}
			MapUtil.GetTrackPositionByTrackTarget(this.TrackTarget, true, this.TempTrackPosition, new int?(this.TrackInstanceId), true);
			if (!this.Offset.Equals(global::Vector.ZeroVectorProxy, 9.999999747378752E-05))
			{
				TTrackTarget_AActor ttrackTarget_AActor = this.TrackTarget as TTrackTarget_AActor;
				if (ttrackTarget_AActor != null && ttrackTarget_AActor.Value.IsValid())
				{
					global::Vector vector = global::Vector.Create();
					global::Vector vector2 = vector;
					FTransformDouble ftransformDouble = ttrackTarget_AActor.Value.D_GetTransform();
					FVectorDouble fvectorDouble = this.Offset.ToUeVector(false);
					FVectorDouble fvectorDouble2 = ftransformDouble.TransformPositionNoScale(fvectorDouble);
					vector2.FromUeVector(fvectorDouble2);
					this.TempTrackPosition = vector;
				}
			}
			double trackDistance = global::Vector.Distance(playerLocation, this.TempTrackPosition) * 0.009999999776482582;
			this.TrackDistance = trackDistance;
			TrackModel.Instance.UpdateGroupMinDistance(this.ShowGroupId.GetValueOrDefault(0), trackDistance);
		}

		// Token: 0x0603257D RID: 206205 RVA: 0x00E1DDC8 File Offset: 0x00E1BFC8
		public unsafe virtual void Update(float delta)
		{
			if (GlobalData.World == null)
			{
				Log.Instance.Error(ELogModule.Map, ELogAuthor.LYX, "【疑难杂症】标记固定在屏幕中心，GameWorld为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (UiLayer.Instance.UiRootItem == null)
			{
				Log.Instance.Error(ELogModule.Map, ELogAuthor.LYX, "【疑难杂症】标记固定在屏幕中心，RootItem为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.RootItem == null)
			{
				return;
			}
			TaskTrackedMarkItem taskTrackedMarkItem = this.TaskTrackedMarkItem;
			if (taskTrackedMarkItem != null)
			{
				taskTrackedMarkItem.Update();
			}
			double trackDistance = this.TrackDistance;
			float? num;
			double? num2;
			if (!this.AlreadyCancelTrack)
			{
				num = this.TrackAutoCancelDistance;
				num2 = ((num != null) ? new double?((double)num.GetValueOrDefault()) : null);
				double num3 = trackDistance;
				if (num2.GetValueOrDefault() >= num3 & num2 != null)
				{
					if (this.MarkType != EMarkType.None)
					{
						MapController instance = MapController.Instance;
						TrackMapMarkParams trackMapMarkParams = new TrackMapMarkParams();
						trackMapMarkParams.MarkType = this.MarkType;
						trackMapMarkParams.MarkId = this.MarkId;
						trackMapMarkParams.Track = false;
						Action<ETrackMapMarkResultType, bool> resultCallBack;
						if ((resultCallBack = TrackedMark.<>O.<0>__ResultFunction) == null)
						{
							resultCallBack = (TrackedMark.<>O.<0>__ResultFunction = new Action<ETrackMapMarkResultType, bool>(TrackedMark.<Update>g__ResultFunction|91_0));
						}
						instance.RequestTrackMapMark(trackMapMarkParams, resultCallBack);
						this.AlreadyCancelTrack = true;
					}
					else
					{
						Log instance2 = Log.Instance;
						ELogModule module = ELogModule.Map;
						ELogAuthor author = ELogAuthor.LYX;
						string message = "[追踪标记]->自动取消标记追踪失败，请检查配置或是否逻辑漏传参数";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MarkType", this.MarkType);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MarkId", this.MarkId);
						instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
				}
			}
			this.CurShowTime += delta / 1000f;
			bool flag = this.IsShowTrackingMark();
			bool flag2 = flag != this.IsShowTrackingMarkCurrent;
			this.IsShowTrackingMarkCurrent = flag;
			if (!this.IsShowTrackingMarkCurrent)
			{
				this.SetRootItemState(false);
				return;
			}
			if (flag2)
			{
				this.UpdateIcon(false);
			}
			double num4 = trackDistance;
			num = this.MarkHideDis;
			num2 = ((num != null) ? new double?((double)num.GetValueOrDefault()) : null);
			if ((num4 < num2.GetValueOrDefault() & num2 != null) && !this.FirstStartSequencePlaying)
			{
				this.RootItem.SetUIActive(false);
				if (this.TrackType == ETrackType.AudioHint)
				{
					this.StopWaveNiagara();
				}
				return;
			}
			this.SetRootItemState(true);
			this.UpdatePositionAndRotation(delta);
			UUIItem item = base.GetItem(4);
			if (this.InRange && !this.IsInTrackRange && !this.IsForceHideDistance)
			{
				int num5 = (int)Math.Round(trackDistance);
				if (this.TrackDistanceDisplay != num5)
				{
					this.TrackDistanceDisplay = num5;
					LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_Meter_Text", new <>z__ReadOnlySingleElementList<object>(this.TrackDistanceDisplay.ToString()));
				}
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUISprite sprite = base.GetSprite(12);
				if (sprite != null)
				{
					sprite.SetUIActive(AutoPilotModel.Instance.GetIsTracking(this.MarkId));
				}
			}
			else
			{
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUISprite sprite2 = base.GetSprite(12);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(false);
				}
			}
			if (this.TrackType == ETrackType.AudioHint)
			{
				this.UpdateAudioHintDisplay(delta);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!this.IsInTrackRange && !this.IsForceHideIcon);
		}

		// Token: 0x0603257E RID: 206206 RVA: 0x00E1E0FC File Offset: 0x00E1C2FC
		protected virtual void UpdatePositionAndRotation(float delta)
		{
			TsCharacterController characterController = Global.CharacterController;
			FVectorDouble fvectorDouble = this.TempTrackPosition.ToUeVector(false);
			bool flag = UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref this.ScreenPositionRef, false);
			if (!flag)
			{
				FTransformDouble value = CameraModel.Instance.MainModel.CameraTransform.Value;
				FVectorDouble fvectorDouble2 = value.InverseTransformPositionNoScale(fvectorDouble);
				fvectorDouble2.X = -fvectorDouble2.X;
				FVectorDouble fvectorDouble3 = value.TransformPositionNoScale(fvectorDouble2);
				UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble3, ref this.ScreenPositionRef, false);
			}
			FVector2D screenPositionRef = this.ScreenPositionRef;
			this.ScreenPosition.Set((double)screenPositionRef.X, (double)screenPositionRef.Y);
			if (!this.LastScreenPosition.Equals(this.ScreenPosition, 1.0) || this.NiagaraNeedActivateNextTick)
			{
				this.LastScreenPosition.DeepCopy(this.ScreenPosition);
				BattleUiModel instance = BattleUiModel.Instance;
				this.ScreenPosition.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset).MultiplyEqual(this.PointTransport);
				this.InRange = this.ClampToEllipse(this.ScreenPosition, flag);
				Vector2D vector2D = this.ScreenPosition.AdditionEqual(TrackDefine.center);
				this.RootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
				UUIItem item = base.GetItem(2);
				if (!this.InRange && !this.IsInTrackRange && !this.IsForceHideDirection)
				{
					this.TempRotator.Reset();
					this.TempRotator.Yaw = (float)(Math.Atan2(this.ScreenPosition.Y, this.ScreenPosition.X) * 57.2957763671875);
					if (item != null)
					{
						UUIItem uuiitem = item;
						FRotator frotator = this.TempRotator.ToUeRotator();
						uuiitem.SetUIRelativeRotation(frotator);
					}
					if (item != null)
					{
						item.SetUIActive(true);
					}
				}
				else if (item != null)
				{
					item.SetUIActive(false);
				}
				UUINiagara uiNiagara = base.GetUiNiagara(5);
				if (!this.InRange && this.TrackType == ETrackType.AudioHint)
				{
					float value2 = (float)(Math.Atan2(this.ScreenPosition.Y, this.ScreenPosition.X) / 6.283185307179586);
					if (uiNiagara != null)
					{
						uiNiagara.SetNiagaraVarFloat("Rotation", value2);
						return;
					}
				}
				else if (uiNiagara != null)
				{
					uiNiagara.SetNiagaraVarFloat("Rotation", 0.25f);
				}
			}
		}

		// Token: 0x0603257F RID: 206207 RVA: 0x00E1E338 File Offset: 0x00E1C538
		public Vector2D MoveTowards(Vector2D current, Vector2D target, float speed)
		{
			double num = target.X - current.X;
			double num2 = target.Y - current.Y;
			float num3 = (float)Math.Sqrt(num * num + num2 * num2);
			float num4 = (float)Math.Atan2(num2, num);
			float num5 = speed * Math.Abs(num3) / (num3 + 1f);
			return new Vector2D(current.X + (double)(num5 * (float)Math.Cos((double)num4)), current.Y + (double)(num5 * (float)Math.Sin((double)num4)));
		}

		// Token: 0x06032580 RID: 206208 RVA: 0x00E1E3B8 File Offset: 0x00E1C5B8
		private bool IsShowTrackingMark()
		{
			if (RecallQuestModel.Instance.IsInRecallInstance())
			{
				TaskTrackedMarkItem taskTrackedMarkItem = this.TaskTrackedMarkItem;
				BtType? btType = (taskTrackedMarkItem != null) ? taskTrackedMarkItem.BtType : null;
				if (btType.GetValueOrDefault() == BtType.Quest)
				{
					return false;
				}
				if ((this.TrackSource == ETrackSource.MapMark || this.TrackSource == ETrackSource.Instance) && btType.GetValueOrDefault() != BtType.Recall && this.TrackInstanceId != CreatureModel.Instance.GetInstanceId())
				{
					return false;
				}
			}
			global::Vector tempTrackPosition = this.TempTrackPosition;
			if (tempTrackPosition != null && tempTrackPosition.IsNearlyZero(9.999999747378752E-05))
			{
				return false;
			}
			if (this.IsOccupied || this.IsOccupiedByInteractionSpot)
			{
				return false;
			}
			if (this.AutoHide && this.CurShowTime > this.ConfigShowTime)
			{
				return false;
			}
			if (this.TaskTrackedMarkItem != null && this.TaskTrackedMarkItem.TargetInDiffWorld())
			{
				return false;
			}
			if (!TrackModel.Instance.CanShowInGroup(this.ShowGroupId.GetValueOrDefault(0), this.TrackDistance) || !this.ShouldShowTrackMark)
			{
				return false;
			}
			TTrackTarget_Int ttrackTarget_Int = this.TrackTarget as TTrackTarget_Int;
			if (ttrackTarget_Int != null && !CreatureModel.Instance.CheckEntityVisible(ttrackTarget_Int.Value))
			{
				return false;
			}
			if (GameModeController.Instance.IsInInstance() && !RecallQuestModel.Instance.IsInRecallInstance())
			{
				bool flag = false;
				foreach (ETrackSource type in this.TrackMarkSourceTypeList)
				{
					flag = (flag || TrackModel.Instance.IsTracking(type, this.MarkId));
					if (flag)
					{
						break;
					}
				}
				return flag;
			}
			return TrackModel.Instance.IsTracking(this.TrackSource, this.MarkId);
		}

		// Token: 0x06032581 RID: 206209 RVA: 0x00E1E544 File Offset: 0x00E1C744
		protected bool ClampToEllipse(Vector2D vector, bool inFront)
		{
			double x = vector.X;
			double y = vector.Y;
			float limitA = this.LimitA;
			float limitB = this.LimitB;
			if (inFront && x * x / (double)(limitA * limitA) + y * y / (double)(limitB * limitB) <= 1.0)
			{
				return true;
			}
			float num = limitA * limitB / (float)Math.Sqrt((double)(limitB * limitB) * x * x + (double)(limitA * limitA) * y * y);
			vector.MultiplyEqual((double)num);
			return false;
		}

		// Token: 0x06032582 RID: 206210 RVA: 0x00E1E5B6 File Offset: 0x00E1C7B6
		private void OnQuestTrackUpdate(BtType contextType, long? _)
		{
			if ((contextType != BtType.Quest && contextType != BtType.Recall) || this.IsInTrackRange)
			{
				return;
			}
			this.PlayTrackStartSequence(0f);
		}

		// Token: 0x06032583 RID: 206211 RVA: 0x00E1E5D4 File Offset: 0x00E1C7D4
		private void OnOnLogicTreeNodeStatusChange(GeneralContext context, NodeStatus oldStatus, NodeStatus newStatus, ENodeStatusUpdateReason reason)
		{
			GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
			if (generalLogicTreeContext == null)
			{
				return;
			}
			if (generalLogicTreeContext.BtType != BtType.Quest && generalLogicTreeContext.BtType != BtType.Recall)
			{
				return;
			}
			this.PlayTrackStartSequence(0f);
		}

		// Token: 0x06032584 RID: 206212 RVA: 0x00E1E60C File Offset: 0x00E1C80C
		private void OnPlaySoundTrackEffect(float effectDuration)
		{
			if (this.TrackType != ETrackType.AudioHint)
			{
				return;
			}
			if (effectDuration <= 0f)
			{
				return;
			}
			if (!this.RootItem.IsUIActiveSelf())
			{
				return;
			}
			this.StopWaveNiagara();
			this.NiagaraDuration = effectDuration / 1000f;
			this.CurNiagaraShowTime = 0f;
			this.NiagaraNeedActivateNextTick = true;
		}

		// Token: 0x06032585 RID: 206213 RVA: 0x00E1E660 File Offset: 0x00E1C860
		private void PlayTrackStartSequence(float _ = 0f)
		{
			if (this.IconTextureLevelSequencePlayer == null)
			{
				return;
			}
			string text = this.IsWeakTrackExpress ? "TrackB" : "TrackA";
			if (!this.IsNewTrackExpress)
			{
				text = "TrackC";
			}
			string currentSequence = this.IconTextureLevelSequencePlayer.GetCurrentSequence();
			if (this.IsForceNotPlayStartSeq)
			{
				if (currentSequence == text)
				{
					this.IconTextureLevelSequencePlayer.StopCurrentSequence(true, true);
					return;
				}
				this.IconTextureLevelSequencePlayer.PlayLevelSequenceByName(text, false, null, false);
				this.IconTextureLevelSequencePlayer.StopCurrentSequence(true, true);
				return;
			}
			else
			{
				if (currentSequence == text)
				{
					return;
				}
				if (this.IconComp.bIsUIActive)
				{
					this.CurShowTime = 0f;
					this.IconTextureLevelSequencePlayer.PlayLevelSequenceByName(text, false, null, false);
				}
				return;
			}
		}

		// Token: 0x06032586 RID: 206214 RVA: 0x00E1E722 File Offset: 0x00E1C922
		private void OnTaskRangeTrackStateChange(ETrackSource trackSource, long treeIncId, int behaviorId, int markId, bool rangeImageActive)
		{
			if (trackSource != this.TrackSource || markId != this.MarkId)
			{
				return;
			}
			this.IsInTrackRange = rangeImageActive;
			UUIItem iconComp = this.IconComp;
			if (iconComp == null)
			{
				return;
			}
			iconComp.SetUIActive(!rangeImageActive);
		}

		// Token: 0x06032587 RID: 206215 RVA: 0x00E1E758 File Offset: 0x00E1C958
		private void UpdateAudioHintDisplay(float delta)
		{
			if (this.TrackType != ETrackType.AudioHint)
			{
				return;
			}
			if (!this.WaveNiagara.IsUIActiveSelf() && !this.NiagaraNeedActivateNextTick)
			{
				return;
			}
			if (this.NiagaraNeedActivateNextTick)
			{
				this.NiagaraNeedActivateNextTick = false;
				this.WaveNiagara.SetNiagaraVarFloat("LifeTime", this.NiagaraDuration);
				if (this.TrackDistance <= this.AudioNearRadius)
				{
					this.WaveNiagara.SetNiagaraVarFloat("Scale", 1f);
					UUINiagara waveNiagara = this.WaveNiagara;
					string varName = "Color";
					FColor fcolor = FColor.FromHex("86FF83");
					waveNiagara.SetNiagaraVarLinearColor(varName, new FLinearColor(ref fcolor));
				}
				else if (this.TrackDistance > this.AudioNearRadius && this.TrackDistance <= this.AudioMiddleRadius)
				{
					this.WaveNiagara.SetNiagaraVarFloat("Scale", 0.6666667f);
					UUINiagara waveNiagara2 = this.WaveNiagara;
					string varName2 = "Color";
					FColor fcolor = FColor.FromHex("FFE683");
					waveNiagara2.SetNiagaraVarLinearColor(varName2, new FLinearColor(ref fcolor));
				}
				else if (this.TrackDistance > this.AudioMiddleRadius && this.TrackDistance <= this.AudioFarRadius)
				{
					this.WaveNiagara.SetNiagaraVarFloat("Scale", 0.33333334f);
					UUINiagara waveNiagara3 = this.WaveNiagara;
					string varName3 = "Color";
					FColor fcolor = FColor.FromHex("FFFFFF");
					waveNiagara3.SetNiagaraVarLinearColor(varName3, new FLinearColor(ref fcolor));
				}
				this.WaveNiagara.SetUIActive(true);
			}
			if (this.CurNiagaraShowTime >= this.NiagaraDuration)
			{
				this.StopWaveNiagara();
				return;
			}
			this.CurNiagaraShowTime += delta / 1000f;
		}

		// Token: 0x06032588 RID: 206216 RVA: 0x00E1E8D4 File Offset: 0x00E1CAD4
		private void StopWaveNiagara()
		{
			this.WaveNiagara.SetUIActive(false);
			this.NiagaraDuration = 0f;
			this.CurNiagaraShowTime = 0f;
			this.NiagaraNeedActivateNextTick = false;
		}

		// Token: 0x06032589 RID: 206217 RVA: 0x00E1E900 File Offset: 0x00E1CB00
		private void SetRootItemState(bool bActive)
		{
			if (this.RootItem == null)
			{
				return;
			}
			if (this.RootItem.IsUIActiveSelf() == bActive)
			{
				return;
			}
			if (bActive)
			{
				this.RootItem.SetUIActive(true);
				this.PlayTrackStartSequence(0f);
				return;
			}
			if (this.TrackDistanceDisplay < 0)
			{
				this.RootItem.SetUIActive(false);
				return;
			}
			LevelSequencePlayer iconTextureLevelSequencePlayer = this.IconTextureLevelSequencePlayer;
			if (iconTextureLevelSequencePlayer == null)
			{
				return;
			}
			iconTextureLevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x0603258A RID: 206218 RVA: 0x00E1E976 File Offset: 0x00E1CB76
		[CompilerGenerated]
		internal static void <Update>g__ResultFunction|91_0(ETrackMapMarkResultType result, bool track)
		{
			if (result == ETrackMapMarkResultType.Success)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("MapTrackingCanceled_Text", Array.Empty<object>());
			}
		}

		// Token: 0x0401AAE3 RID: 109283
		private const string WAVE_COLOR_NEAR = "86FF83";

		// Token: 0x0401AAE4 RID: 109284
		private const string WAVE_COLOR_MIDDLE = "FFE683";

		// Token: 0x0401AAE5 RID: 109285
		private const string WAVE_COLOR_FAR = "FFFFFF";

		// Token: 0x0401AAE6 RID: 109286
		private const string VARNAME_WAVE_CYCLE_TIME = "LifeTime";

		// Token: 0x0401AAE7 RID: 109287
		private const string VARNAME_WAVE_NUM_SCALE = "Scale";

		// Token: 0x0401AAE8 RID: 109288
		private const string VARNAME_WAVE_COLOR = "Color";

		// Token: 0x0401AAE9 RID: 109289
		private const string VARNAME_WAVE_ROTATION = "Rotation";

		// Token: 0x0401AAEA RID: 109290
		private const string TRACKA = "TrackA";

		// Token: 0x0401AAEB RID: 109291
		private const string TRACKB = "TrackB";

		// Token: 0x0401AAEC RID: 109292
		private const string TRACKC = "TrackC";

		// Token: 0x0401AAED RID: 109293
		private const int DELAY_TIME = 500;

		// Token: 0x0401AAEE RID: 109294
		private const float SUB_SCALE = 0.8f;

		// Token: 0x0401AAEF RID: 109295
		private const int QUEST_TRACK_MARK_INDEX = 999;

		// Token: 0x0401AAF0 RID: 109296
		[Nullable(2)]
		public TTrackTarget TrackTarget;

		// Token: 0x0401AAF1 RID: 109297
		private readonly int TrackInstanceId;

		// Token: 0x0401AAF2 RID: 109298
		protected readonly bool IsSubTrack;

		// Token: 0x0401AAF3 RID: 109299
		private readonly float? TrackAutoCancelDistance;

		// Token: 0x0401AAF4 RID: 109300
		private bool AlreadyCancelTrack;

		// Token: 0x0401AAF5 RID: 109301
		private bool IsOccupied;

		// Token: 0x0401AAF6 RID: 109302
		private bool IsOccupiedByInteractionSpot;

		// Token: 0x0401AAF7 RID: 109303
		private string IconPath = string.Empty;

		// Token: 0x0401AAF8 RID: 109304
		private readonly float LimitA;

		// Token: 0x0401AAF9 RID: 109305
		private readonly float LimitB;

		// Token: 0x0401AAFA RID: 109306
		protected FVector2D ScreenPositionRef = new FVector2D();

		// Token: 0x0401AAFB RID: 109307
		protected FVector2D PointTransport = new FVector2D(1f, -1f);

		// Token: 0x0401AAFC RID: 109308
		protected readonly float? MarkHideDis = new float?(0f);

		// Token: 0x0401AAFD RID: 109309
		private readonly int? ShowGroupId = new int?(0);

		// Token: 0x0401AAFE RID: 109310
		private readonly int MarkId;

		// Token: 0x0401AAFF RID: 109311
		private readonly EMarkType MarkType;

		// Token: 0x0401AB00 RID: 109312
		private readonly ETrackSource TrackSource;

		// Token: 0x0401AB01 RID: 109313
		[Nullable(2)]
		private TimerHandle DelayTrackSequenceTimerId;

		// Token: 0x0401AB02 RID: 109314
		protected bool IsInTrackRange;

		// Token: 0x0401AB03 RID: 109315
		[Nullable(2)]
		protected global::Vector TempTrackPosition;

		// Token: 0x0401AB04 RID: 109316
		[Nullable(2)]
		protected readonly Vector2D ScreenPosition;

		// Token: 0x0401AB05 RID: 109317
		[Nullable(2)]
		protected readonly Vector2D LastScreenPosition;

		// Token: 0x0401AB06 RID: 109318
		protected bool InRange;

		// Token: 0x0401AB07 RID: 109319
		[Nullable(2)]
		protected readonly global::Rotator TempRotator;

		// Token: 0x0401AB08 RID: 109320
		private double TrackDistance;

		// Token: 0x0401AB09 RID: 109321
		private int TrackDistanceDisplay = -1;

		// Token: 0x0401AB0A RID: 109322
		public bool ShouldShowTrackMark = true;

		// Token: 0x0401AB0B RID: 109323
		[Nullable(2)]
		private LevelSequencePlayer IconTextureLevelSequencePlayer;

		// Token: 0x0401AB0C RID: 109324
		private readonly global::Vector Offset = global::Vector.Create();

		// Token: 0x0401AB0D RID: 109325
		private readonly bool AutoHide;

		// Token: 0x0401AB0E RID: 109326
		private bool FirstStartSequencePlaying;

		// Token: 0x0401AB0F RID: 109327
		[Nullable(2)]
		private UUIItem DistanceComp;

		// Token: 0x0401AB10 RID: 109328
		[Nullable(2)]
		protected UUIItem DirectionComp;

		// Token: 0x0401AB11 RID: 109329
		[Nullable(2)]
		private UUIItem IconComp;

		// Token: 0x0401AB12 RID: 109330
		[Nullable(2)]
		private UUINiagara WaveNiagara;

		// Token: 0x0401AB13 RID: 109331
		protected bool NiagaraNeedActivateNextTick;

		// Token: 0x0401AB14 RID: 109332
		private float NiagaraDuration;

		// Token: 0x0401AB15 RID: 109333
		private float CurNiagaraShowTime;

		// Token: 0x0401AB16 RID: 109334
		protected float CurShowTime;

		// Token: 0x0401AB17 RID: 109335
		private readonly float ConfigShowTime;

		// Token: 0x0401AB18 RID: 109336
		private readonly bool IsForceHideDistance;

		// Token: 0x0401AB19 RID: 109337
		protected readonly bool IsForceHideDirection;

		// Token: 0x0401AB1A RID: 109338
		private readonly bool IsForceHideIcon;

		// Token: 0x0401AB1B RID: 109339
		private readonly bool IsForceNotPlayStartSeq;

		// Token: 0x0401AB1C RID: 109340
		private readonly ETrackType TrackType;

		// Token: 0x0401AB1D RID: 109341
		private readonly double AudioNearRadius;

		// Token: 0x0401AB1E RID: 109342
		private readonly double AudioMiddleRadius;

		// Token: 0x0401AB1F RID: 109343
		private readonly double AudioFarRadius;

		// Token: 0x0401AB20 RID: 109344
		[Nullable(2)]
		private TaskTrackedMarkItem TaskTrackedMarkItem;

		// Token: 0x0401AB21 RID: 109345
		private bool IsShowTrackingMarkCurrent;

		// Token: 0x0401AB22 RID: 109346
		private readonly bool IsWeakTrackExpress;

		// Token: 0x0401AB23 RID: 109347
		private readonly bool IsNewTrackExpress;

		// Token: 0x0401AB24 RID: 109348
		[Nullable(2)]
		private readonly string MarkRingPic;

		// Token: 0x0401AB25 RID: 109349
		[Nullable(2)]
		private readonly string MarkIconPic;

		// Token: 0x0401AB26 RID: 109350
		[Nullable(2)]
		private readonly string MarkRingColor;

		// Token: 0x0401AB27 RID: 109351
		[Nullable(2)]
		private readonly string SmallHaloColor;

		// Token: 0x0401AB28 RID: 109352
		[Nullable(2)]
		private readonly string LargeHaloColor;

		// Token: 0x0401AB29 RID: 109353
		private readonly ETrackSource[] TrackMarkSourceTypeList = new ETrackSource[]
		{
			ETrackSource.Instance,
			ETrackSource.SceneGameplay,
			ETrackSource.NearbyTrack
		};

		// Token: 0x0200ABD5 RID: 43989
		[NullableContext(0)]
		private enum ETrackedMark
		{
			// Token: 0x040352DA RID: 217818
			Icon,
			// Token: 0x040352DB RID: 217819
			Distance,
			// Token: 0x040352DC RID: 217820
			Direction,
			// Token: 0x040352DD RID: 217821
			TrackedButton,
			// Token: 0x040352DE RID: 217822
			DistanceItem,
			// Token: 0x040352DF RID: 217823
			WaveNiagara,
			// Token: 0x040352E0 RID: 217824
			PanelIcon,
			// Token: 0x040352E1 RID: 217825
			SpriteOverview,
			// Token: 0x040352E2 RID: 217826
			SpriteLightB,
			// Token: 0x040352E3 RID: 217827
			SpriteLightA,
			// Token: 0x040352E4 RID: 217828
			SpriteCircle,
			// Token: 0x040352E5 RID: 217829
			PanelCircle,
			// Token: 0x040352E6 RID: 217830
			SpiteDistance,
			// Token: 0x040352E7 RID: 217831
			SpriteStateDown,
			// Token: 0x040352E8 RID: 217832
			SpriteStateUp
		}

		// Token: 0x0200ABD6 RID: 43990
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040352E9 RID: 217833
			[Nullable(0)]
			public static Action<ETrackMapMarkResultType, bool> <0>__ResultFunction;
		}
	}
}
