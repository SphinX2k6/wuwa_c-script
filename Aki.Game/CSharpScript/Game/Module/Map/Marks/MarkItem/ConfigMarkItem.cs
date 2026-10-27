using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054D9 RID: 21721
	[NullableContext(1)]
	[Nullable(0)]
	public class ConfigMarkItem : MarkItem
	{
		// Token: 0x1700851C RID: 34076
		// (get) Token: 0x06037741 RID: 227137 RVA: 0x00D2C1B6 File Offset: 0x00D2A3B6
		public virtual bool IsFogUnlock
		{
			get
			{
				return MapModel.Instance.IsMarkFogUnlock(this.MarkConfigId);
			}
		}

		// Token: 0x1700851D RID: 34077
		// (get) Token: 0x06037742 RID: 227138 RVA: 0x00D2C1C8 File Offset: 0x00D2A3C8
		public virtual bool IsLocked
		{
			get
			{
				return base.MarkItemEntity.GamePlay.IsTeleportLocked;
			}
		}

		// Token: 0x1700851E RID: 34078
		// (get) Token: 0x06037743 RID: 227139 RVA: 0x00D2C1DA File Offset: 0x00D2A3DA
		public override EMarkItemType MarkItemType
		{
			get
			{
				return EMarkItemType.Config;
			}
		}

		// Token: 0x06037744 RID: 227140 RVA: 0x00D2C1E0 File Offset: 0x00D2A3E0
		public override bool IsMultiMap()
		{
			return this.MarkConfig.Value.MultiMapFloorId != 0 || this.GetConnectMultiMapIds().Length > 0;
		}

		// Token: 0x06037745 RID: 227141 RVA: 0x00D2C218 File Offset: 0x00D2A418
		public override bool LocateInGround()
		{
			return this.MarkConfig.Value.MultiMapFloorId == 0 && this.GetConnectMultiMapIds().Length > 0;
		}

		// Token: 0x06037746 RID: 227142 RVA: 0x00D2C250 File Offset: 0x00D2A450
		public unsafe override bool ConnectGround()
		{
			if (this.IsMultiMap())
			{
				int multiMapFloorId = this.MarkConfig.Value.MultiMapFloorId;
				if (multiMapFloorId != 0)
				{
					MultiMap? subMapConfigById = MapConfig.Instance.GetSubMapConfigById(multiMapFloorId);
					if (subMapConfigById != null && subMapConfigById.GetValueOrDefault().Floor == 0)
					{
						return true;
					}
				}
				Span<int> connectMultiMapIds = this.GetConnectMultiMapIds();
				for (int i = 0; i < connectMultiMapIds.Length; i++)
				{
					int id = *connectMultiMapIds[i];
					MultiMap? subMapConfigById2 = MapConfig.Instance.GetSubMapConfigById(id);
					if (subMapConfigById2 != null && subMapConfigById2.GetValueOrDefault().Floor == 0)
					{
						return true;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x06037747 RID: 227143 RVA: 0x00D2C30C File Offset: 0x00D2A50C
		public unsafe override int GetMultiMapId()
		{
			int multiMapFloorId = this.MarkConfig.Value.MultiMapFloorId;
			if (multiMapFloorId != 0)
			{
				return multiMapFloorId;
			}
			Span<int> connectMultiMapIds = this.GetConnectMultiMapIds();
			if (connectMultiMapIds.Length <= 0)
			{
				return 0;
			}
			return *connectMultiMapIds[0];
		}

		// Token: 0x06037748 RID: 227144 RVA: 0x00D2C350 File Offset: 0x00D2A550
		[NullableContext(0)]
		public Span<int> GetConnectMultiMapIds()
		{
			return this.MarkConfig.Value.GetConnetMultiMapFloorIdBytes();
		}

		// Token: 0x1700851F RID: 34079
		// (get) Token: 0x06037749 RID: 227145 RVA: 0x00D2C370 File Offset: 0x00D2A570
		// (set) Token: 0x0603774A RID: 227146 RVA: 0x00D2C378 File Offset: 0x00D2A578
		public override int MarkId
		{
			get
			{
				return this.InnerMarkId;
			}
			set
			{
				this.InnerMarkId = value;
			}
		}

		// Token: 0x17008520 RID: 34080
		// (get) Token: 0x0603774B RID: 227147 RVA: 0x00D2C384 File Offset: 0x00D2A584
		public int MarkConfigId
		{
			get
			{
				return this.MarkConfig.Value.MarkId;
			}
		}

		// Token: 0x17008521 RID: 34081
		// (get) Token: 0x0603774C RID: 227148 RVA: 0x00D2C3A4 File Offset: 0x00D2A5A4
		public override EMarkType MarkType
		{
			get
			{
				return (EMarkType)this.MarkConfig.Value.ObjectType;
			}
		}

		// Token: 0x17008522 RID: 34082
		// (get) Token: 0x0603774D RID: 227149 RVA: 0x00D2C3C4 File Offset: 0x00D2A5C4
		public override int MapId
		{
			get
			{
				return this.MarkConfig.Value.MapId;
			}
		}

		// Token: 0x17008523 RID: 34083
		// (get) Token: 0x0603774E RID: 227150 RVA: 0x00D2C3E4 File Offset: 0x00D2A5E4
		public override int? InstanceDungeonId
		{
			get
			{
				return new int?(this.MarkConfig.Value.InstanceDungeonId);
			}
		}

		// Token: 0x17008524 RID: 34084
		// (get) Token: 0x0603774F RID: 227151 RVA: 0x00D2C40C File Offset: 0x00D2A60C
		public override int? RelativeInstanceDungeonId
		{
			get
			{
				return new int?(this.MarkConfig.Value.RelativeDungeonId);
			}
		}

		// Token: 0x06037750 RID: 227152 RVA: 0x00D2C434 File Offset: 0x00D2A634
		public ConfigMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(parent, mapType, markScale, trackSource ?? ((markConfig.InstanceDungeonId != 0) ? ETrackSource.Instance : ETrackSource.MapMark))
		{
			this.InnerMarkId = markId;
			base.ShowPriority = markConfig.ShowPriority;
			this.MarkConfig = new MapMark?(markConfig);
			this.IconPath = this.MarkConfig.Value.LockMarkPic;
		}

		// Token: 0x06037751 RID: 227153 RVA: 0x00D2C4B0 File Offset: 0x00D2A6B0
		protected override void OnInitialize()
		{
			if (this.MarkConfig.Value.Scale != 0f)
			{
				base.SetConfigScale(this.MarkConfig.Value.Scale);
			}
			if (this.MarkConfig.Value.CornerScale != 0f)
			{
				base.SetCornerScale(this.MarkConfig.Value.CornerScale);
			}
			this.InitShowCondition();
			this.InitPosition();
			this.InitIcon();
		}

		// Token: 0x06037752 RID: 227154 RVA: 0x00D2C535 File Offset: 0x00D2A735
		protected virtual void InitPosition()
		{
			base.SetTrackData(MapModel.Instance.GetConfigMarkTrackTarget(this.MarkId));
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x06037753 RID: 227155 RVA: 0x00D2C553 File Offset: 0x00D2A753
		protected virtual void InitIcon()
		{
			this.UpdateIconPath();
		}

		// Token: 0x06037754 RID: 227156 RVA: 0x00D2C55C File Offset: 0x00D2A75C
		public virtual void UpdateIconPath()
		{
			if (this.MarkConfig.Value.RelativeSubType <= 0)
			{
				return;
			}
			if (this.MarkConfig.Value.RelativeSubType == 7)
			{
				this.IconPath = (MapModel.Instance.IsInstanceTeleportUnlock(this.MarkId) ? this.MarkConfig.Value.UnlockMarkPic : this.MarkConfig.Value.LockMarkPic);
				return;
			}
			this.IconPath = this.MarkConfig.Value.LockMarkPic;
		}

		// Token: 0x06037755 RID: 227157 RVA: 0x00D2C5F4 File Offset: 0x00D2A7F4
		public bool IsRelativeFunctionOpen()
		{
			if (this.MarkConfig.Value.RelativeSubType <= 0)
			{
				return true;
			}
			MapMarkRelativeSubType? mapMarkFuncTypeConfigById = MapConfig.Instance.GetMapMarkFuncTypeConfigById(this.MarkConfig.Value.RelativeSubType);
			return mapMarkFuncTypeConfigById == null || mapMarkFuncTypeConfigById.Value.FunctionId <= 0 || FunctionModel.Instance.IsOpen(mapMarkFuncTypeConfigById.Value.FunctionId);
		}

		// Token: 0x06037756 RID: 227158 RVA: 0x00D2C66D File Offset: 0x00D2A86D
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.ConfigMarkItemView;
		}

		// Token: 0x06037757 RID: 227159 RVA: 0x00D2C670 File Offset: 0x00D2A870
		protected override MarkItemView CreateView()
		{
			return new ConfigMarkItemView(this);
		}

		// Token: 0x06037758 RID: 227160 RVA: 0x00D2C678 File Offset: 0x00D2A878
		public override string GetLocaleDesc()
		{
			return this.MarkConfig.Value.MarkDesc;
		}

		// Token: 0x06037759 RID: 227161 RVA: 0x00D2C698 File Offset: 0x00D2A898
		public override string GetTitleText()
		{
			return MapConfig.Instance.GetLocalText(this.MarkConfig.Value.MarkTitle);
		}

		// Token: 0x0603775A RID: 227162 RVA: 0x00D2C6C4 File Offset: 0x00D2A8C4
		[NullableContext(2)]
		public string GetAreaText()
		{
			if (!(base.TrackTarget is TTrackTarget_Int))
			{
				return null;
			}
			MapMark? mapMark;
			string[] array = ((MapConfig.Instance.GetConfigMark(this.MarkId) != null) ? mapMark.GetValueOrDefault().AreaShowText() : null) ?? Array.Empty<string>();
			if (array.Length != 0)
			{
				return string.Join("-", from item in array
				select MapConfig.Instance.GetLocalText(item));
			}
			return MapModel.Instance.GetMarkAreaText(this.MapId, ((TTrackTarget_Int)base.TrackTarget).Value);
		}

		// Token: 0x17008525 RID: 34085
		// (get) Token: 0x0603775B RID: 227163 RVA: 0x00D2C76C File Offset: 0x00D2A96C
		public override int? TrackAreaId
		{
			get
			{
				TTrackTarget_Int ttrackTarget_Int = base.TrackTarget as TTrackTarget_Int;
				if (ttrackTarget_Int == null)
				{
					return null;
				}
				return MapModel.GetEntityConfigAreaId(this.MapId, ttrackTarget_Int.Value);
			}
		}

		// Token: 0x0603775C RID: 227164 RVA: 0x00D2C7A4 File Offset: 0x00D2A9A4
		protected bool CheckInShowRange(float scale)
		{
			MapMark value = this.MarkConfig.Value;
			return (float)value.ShowRange(0) < scale && (float)value.ShowRange(1) > scale;
		}

		// Token: 0x17008526 RID: 34086
		// (get) Token: 0x0603775D RID: 227165 RVA: 0x00D2C7D7 File Offset: 0x00D2A9D7
		public bool IsConditionShouldShow
		{
			get
			{
				return this.ConditionShouldShow && (!this.IsServerSaveShowState || MapModel.Instance.GetMarkExtraShowState(this.MarkId).ShowFlag != MapMarkShowFlag.Hide) && this.ConditionShouldShow;
			}
		}

		// Token: 0x17008527 RID: 34087
		// (get) Token: 0x0603775E RID: 227166 RVA: 0x00D2C80A File Offset: 0x00D2AA0A
		public bool IsConditionShouldShowWithoutServerState
		{
			get
			{
				return this.ConditionShouldShow;
			}
		}

		// Token: 0x0603775F RID: 227167 RVA: 0x00D2C814 File Offset: 0x00D2AA14
		protected void InitShowCondition()
		{
			int showCondition = this.MarkConfig.Value.ShowCondition;
			this.CachedShowConditionPositive = (showCondition > 0);
			if (showCondition < 0)
			{
				this.IsServerSaveShowState = true;
				return;
			}
			if (showCondition == 0)
			{
				this.ConditionShouldShow = true;
				return;
			}
			this.IsServerSaveShowState = false;
			this.ConditionShouldShow = MapModel.Instance.IsMarkUnlockedByServer(this.MarkId);
		}

		// Token: 0x06037760 RID: 227168 RVA: 0x00D2C874 File Offset: 0x00D2AA74
		public override bool CheckCanShowView()
		{
			if (!this.CanConditionShowView())
			{
				return base.IsTracked;
			}
			float currentMapShowScale = this.GetCurrentMapShowScale();
			bool flag = this.CheckInShowRange(currentMapShowScale) || base.IsTracked;
			if (base.MapType == EMapType.WorldMap)
			{
				bool isCanShowViewIntermediately = base.IsCanShowViewIntermediately;
				bool flag2 = flag || base.IsIgnoreScaleShow;
				if (isCanShowViewIntermediately != flag2)
				{
					base.NeedPlayShowOrHideSeq = (flag2 ? "ShowView" : "HideView");
				}
				return flag2;
			}
			return true;
		}

		// Token: 0x06037761 RID: 227169 RVA: 0x00D2C8E4 File Offset: 0x00D2AAE4
		private bool FinishPlayIsShow()
		{
			return this.MarkConfig.Value.FinishIsShow == 1 || WorldMapModel.Instance.CompletedPlayPointMarkIsShow || !this.GamePlayIsFinish();
		}

		// Token: 0x06037762 RID: 227170 RVA: 0x00D2C920 File Offset: 0x00D2AB20
		protected virtual bool GamePlayIsFinish()
		{
			return base.MarkItemEntity.GamePlay.IsFinish;
		}

		// Token: 0x06037763 RID: 227171 RVA: 0x00D2C932 File Offset: 0x00D2AB32
		public bool IsGameplayHasReward()
		{
			return base.MarkItemEntity.GamePlay.GameplayRewardIdList.Count > 0;
		}

		// Token: 0x06037764 RID: 227172 RVA: 0x00D2C94C File Offset: 0x00D2AB4C
		public override bool GamePlayIsDiscover()
		{
			int relativeDungeonId = this.MarkConfig.Value.RelativeDungeonId;
			int relativeId = this.MarkConfig.Value.RelativeId;
			return LevelPlayReportModel.Instance.IsCommonLevelPlayDiscover(relativeDungeonId, relativeId);
		}

		// Token: 0x06037765 RID: 227173 RVA: 0x00D2C990 File Offset: 0x00D2AB90
		public bool CanConditionShowView()
		{
			EMapType mapType = base.MapType;
			int mapShow = this.MarkConfig.Value.MapShow;
			if ((mapShow == 1 && mapType != EMapType.MiniMap) || (mapShow == 2 && mapType == EMapType.MiniMap))
			{
				return false;
			}
			if (base.MarkItemEntity.IsTempMapMark && this.IsTempMapMarkShow())
			{
				return true;
			}
			if (this.CachedShowConditionPositive)
			{
				this.ConditionShouldShow = MapModel.Instance.IsMarkUnlockedByServer(this.MarkId);
			}
			return this.ConditionShouldShow && (!this.IsServerSaveShowState || MapModel.Instance.GetMarkExtraShowState(this.MarkId).ShowFlag != MapMarkShowFlag.Hide) && this.IsFogUnlock && this.FinishPlayIsShow();
		}

		// Token: 0x06037766 RID: 227174 RVA: 0x00D2CA40 File Offset: 0x00D2AC40
		public override float GetShowScale()
		{
			return (float)this.MarkConfig.Value.ShowRange(0) + (float)this.MarkConfig.Value.ShowRange(1) / 2f;
		}

		// Token: 0x06037767 RID: 227175 RVA: 0x00D2CA80 File Offset: 0x00D2AC80
		public bool IsLordGym()
		{
			return this.MarkConfig.Value.RelativeSubType == 3;
		}

		// Token: 0x06037768 RID: 227176 RVA: 0x00D2CAA4 File Offset: 0x00D2ACA4
		public bool IsNewLordGym()
		{
			return this.MarkConfig.Value.RelativeSubType == 8;
		}

		// Token: 0x06037769 RID: 227177 RVA: 0x00D2CAC8 File Offset: 0x00D2ACC8
		public bool IsMoraleFlag()
		{
			return this.MarkConfig.Value.RelativeSubType == 6;
		}

		// Token: 0x0603776A RID: 227178 RVA: 0x00D2CAEC File Offset: 0x00D2ACEC
		public bool IsNightMareFlag()
		{
			return this.MarkConfig.Value.RelativeSubType == 9;
		}

		// Token: 0x0603776B RID: 227179 RVA: 0x00D2CB10 File Offset: 0x00D2AD10
		public bool IsVisionSettlementFlag()
		{
			return this.MarkConfig.Value.RelativeSubType == 10;
		}

		// Token: 0x0603776C RID: 227180 RVA: 0x00D2CB34 File Offset: 0x00D2AD34
		public bool IsFlagChallengeFlag()
		{
			return this.MarkConfig.Value.RelativeSubType == 7;
		}

		// Token: 0x0603776D RID: 227181 RVA: 0x00D2CB58 File Offset: 0x00D2AD58
		public bool IsRedNameProGameplay()
		{
			return this.MarkConfig.Value.RelativeSubType == 13;
		}

		// Token: 0x0603776E RID: 227182 RVA: 0x00D2CB7C File Offset: 0x00D2AD7C
		public void ChangeSubMap(int floorIndex)
		{
			bool flag;
			if (this.LocateInGround() && floorIndex == 0)
			{
				flag = true;
			}
			else
			{
				int multiMapId = this.GetMultiMapId();
				int? worldMapCurrentMultiMapId = WorldMapModel.Instance.WorldMapCurrentMultiMapId;
				flag = (multiMapId == worldMapCurrentMultiMapId.GetValueOrDefault() & worldMapCurrentMultiMapId != null);
			}
			if (base.IsSelectThisFloor == flag)
			{
				return;
			}
			base.IsSelectThisFloor = flag;
			this.UpdateViewIcon();
		}

		// Token: 0x0603776F RID: 227183 RVA: 0x00D2CBD4 File Offset: 0x00D2ADD4
		protected void UpdateViewIcon()
		{
			if (base.View != null && !base.IsDestroy)
			{
				ConfigMarkItemView configMarkItemView = base.View as ConfigMarkItemView;
				if (configMarkItemView.ViewInitialized)
				{
					configMarkItemView.UpdateIcon();
				}
			}
		}

		// Token: 0x0401D391 RID: 119697
		public MapMark? MarkConfig;

		// Token: 0x0401D392 RID: 119698
		protected int InnerMarkId;

		// Token: 0x0401D393 RID: 119699
		protected bool IsServerSaveShowState;

		// Token: 0x0401D394 RID: 119700
		private bool CachedShowConditionPositive;

		// Token: 0x0401D395 RID: 119701
		protected bool ConditionShouldShow = true;
	}
}
