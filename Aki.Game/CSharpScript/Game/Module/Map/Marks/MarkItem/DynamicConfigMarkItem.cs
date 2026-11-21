using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044B1 RID: 17585
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicConfigMarkItem : MarkItem
	{
		// Token: 0x170058B6 RID: 22710
		// (get) Token: 0x0602C641 RID: 181825 RVA: 0x00C7B034 File Offset: 0x00C79234
		public bool IsFogUnlock
		{
			get
			{
				DynamicMapMark value = this.MarkConfig.Value;
				return value.FogShow == 1 || MapModel.Instance.CheckFogUnlocked(value.FogHide, null);
			}
		}

		// Token: 0x170058B7 RID: 22711
		// (get) Token: 0x0602C642 RID: 181826 RVA: 0x00C7B073 File Offset: 0x00C79273
		// (set) Token: 0x0602C643 RID: 181827 RVA: 0x00C7B07B File Offset: 0x00C7927B
		public override int MarkId { get; set; }

		// Token: 0x170058B8 RID: 22712
		// (get) Token: 0x0602C644 RID: 181828 RVA: 0x00C7B084 File Offset: 0x00C79284
		public int MarkConfigId
		{
			get
			{
				return this.MarkConfig.Value.MarkId;
			}
		}

		// Token: 0x170058B9 RID: 22713
		// (get) Token: 0x0602C645 RID: 181829 RVA: 0x00C7B0A4 File Offset: 0x00C792A4
		public override EMarkType MarkType
		{
			get
			{
				return (EMarkType)this.MarkConfig.Value.ObjectType;
			}
		}

		// Token: 0x170058BA RID: 22714
		// (get) Token: 0x0602C646 RID: 181830 RVA: 0x00C7B0C4 File Offset: 0x00C792C4
		// (set) Token: 0x0602C647 RID: 181831 RVA: 0x00C7B0CC File Offset: 0x00C792CC
		public int? OverrideMapId { get; set; }

		// Token: 0x170058BB RID: 22715
		// (get) Token: 0x0602C648 RID: 181832 RVA: 0x00C7B0D5 File Offset: 0x00C792D5
		// (set) Token: 0x0602C649 RID: 181833 RVA: 0x00C7B0DD File Offset: 0x00C792DD
		public EMapGravityDirection? OverrideGravity { get; set; }

		// Token: 0x170058BC RID: 22716
		// (get) Token: 0x0602C64A RID: 181834 RVA: 0x00C7B0E8 File Offset: 0x00C792E8
		public override EMapGravityDirection Gravity
		{
			get
			{
				return this.OverrideGravity.GetValueOrDefault();
			}
		}

		// Token: 0x170058BD RID: 22717
		// (get) Token: 0x0602C64B RID: 181835 RVA: 0x00C7B104 File Offset: 0x00C79304
		public override int MapId
		{
			get
			{
				int? overrideMapId = this.OverrideMapId;
				if (overrideMapId == null)
				{
					return this.MarkConfig.Value.MapId;
				}
				return overrideMapId.GetValueOrDefault();
			}
		}

		// Token: 0x170058BE RID: 22718
		// (get) Token: 0x0602C64C RID: 181836 RVA: 0x00C7B13C File Offset: 0x00C7933C
		public override int? InstanceDungeonId
		{
			get
			{
				return new int?(this.MarkConfig.Value.InstanceDungeonId);
			}
		}

		// Token: 0x0602C64D RID: 181837 RVA: 0x00C7B164 File Offset: 0x00C79364
		public override bool IsMarkDisabled()
		{
			return base.EntityId != null && MapModel.Instance.IsMarkHideByServer(this.MapId, base.EntityId.Value);
		}

		// Token: 0x0602C64E RID: 181838 RVA: 0x00C7B1A4 File Offset: 0x00C793A4
		public DynamicConfigMarkItem(int markId, DynamicMapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(parent, mapType, markScale, trackSource)
		{
			this.MarkId = markId;
			base.ShowPriority = markConfig.ShowPriority;
			this.MarkConfig = new DynamicMapMark?(markConfig);
			this.IconPath = this.MarkConfig.Value.LockMarkPic;
		}

		// Token: 0x0602C64F RID: 181839 RVA: 0x00C7B200 File Offset: 0x00C79400
		protected override void OnInitialize()
		{
			if (this.MarkConfig != null && this.MarkConfig.Value.Scale != 0f)
			{
				base.SetConfigScale(this.MarkConfig.Value.Scale);
			}
			this.InitPosition(this.MarkConfig.Value);
			this.InitShowCondition();
		}

		// Token: 0x0602C650 RID: 181840 RVA: 0x00C7B264 File Offset: 0x00C79464
		private void InitPosition(DynamicMapMark markConfig)
		{
			if (markConfig.EntityConfigId > 0)
			{
				base.SetTrackData(markConfig.EntityConfigId);
				this.UpdateVisibleRelativeState();
				return;
			}
			if (markConfig.MarkVector != null)
			{
				base.SetTrackData(global::Vector.Create((double)markConfig.MarkVector.Value.X, (double)markConfig.MarkVector.Value.Y, (double)markConfig.MarkVector.Value.Z));
				this.UpdateVisibleRelativeState();
			}
		}

		// Token: 0x0602C651 RID: 181841 RVA: 0x00C7B303 File Offset: 0x00C79503
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.DynamicConfigMarkItemView;
		}

		// Token: 0x0602C652 RID: 181842 RVA: 0x00C7B306 File Offset: 0x00C79506
		[PreserveBaseOverrides]
		protected new virtual DynamicConfigMarkItemView CreateView()
		{
			return new DynamicConfigMarkItemView(this);
		}

		// Token: 0x0602C653 RID: 181843 RVA: 0x00C7B310 File Offset: 0x00C79510
		public override string GetLocaleDesc()
		{
			return this.MarkConfig.Value.MarkDesc;
		}

		// Token: 0x0602C654 RID: 181844 RVA: 0x00C7B330 File Offset: 0x00C79530
		public override string GetTitleText()
		{
			return MapConfig.Instance.GetLocalText(this.MarkConfig.Value.MarkTitle);
		}

		// Token: 0x170058BF RID: 22719
		// (get) Token: 0x0602C655 RID: 181845 RVA: 0x00C7B35C File Offset: 0x00C7955C
		public override int? TrackAreaId
		{
			get
			{
				TTrackTarget_Int ttrackTarget_Int = base.TrackTarget as TTrackTarget_Int;
				if (ttrackTarget_Int != null && ttrackTarget_Int != 0)
				{
					return new int?(WorldMapModel.Instance.GetEntityAreaId(ttrackTarget_Int, new int?(this.MapId)));
				}
				int markAreaId = MapModel.Instance.GetMarkAreaId(this.MarkId, this.MarkType);
				if (markAreaId != 0)
				{
					return new int?(markAreaId);
				}
				return null;
			}
		}

		// Token: 0x0602C656 RID: 181846 RVA: 0x00C7B3CC File Offset: 0x00C795CC
		[NullableContext(2)]
		public string GetAreaText()
		{
			if (!(base.TrackTarget is TTrackTarget_Int))
			{
				return null;
			}
			if (this.TrackAreaId != null)
			{
				return MapModel.Instance.GetMarkAreaTextByAreaId(this.TrackAreaId.Value);
			}
			MapMark? mapMark;
			string[] array = (MapConfig.Instance.GetConfigMark(this.MarkConfigId) != null) ? mapMark.GetValueOrDefault().AreaShowText() : null;
			if (array != null && array.Length != 0)
			{
				List<string> list = new List<string>();
				foreach (string textKey in array)
				{
					list.Add(MapConfig.Instance.GetLocalText(textKey));
				}
				return string.Join("-", list);
			}
			return MapModel.Instance.GetMarkAreaText(this.MapId, base.TrackTarget as TTrackTarget_Int);
		}

		// Token: 0x0602C657 RID: 181847 RVA: 0x00C7B4AC File Offset: 0x00C796AC
		private bool CheckInShowRange(float scale)
		{
			DynamicMapMark value = this.MarkConfig.Value;
			return (float)value.ShowRange(0) < scale && (float)value.ShowRange(1) > scale;
		}

		// Token: 0x0602C658 RID: 181848 RVA: 0x00C7B4DF File Offset: 0x00C796DF
		protected void InitShowCondition()
		{
			this.ConditionShouldShow = true;
		}

		// Token: 0x0602C659 RID: 181849 RVA: 0x00C7B4E8 File Offset: 0x00C796E8
		public override bool CheckCanShowView()
		{
			EMapType mapType = base.MapType;
			int mapShow = this.MarkConfig.Value.MapShow;
			if ((mapShow == 1 && mapType != EMapType.MiniMap) || (mapShow == 2 && mapType == EMapType.MiniMap))
			{
				return false;
			}
			if (!this.ConditionShouldShow)
			{
				return false;
			}
			if (!this.IsFogUnlock)
			{
				return false;
			}
			float currentMapShowScale = this.GetCurrentMapShowScale();
			bool flag = this.CheckInShowRange(currentMapShowScale) || base.IsTracked;
			if (mapType == EMapType.WorldMap)
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

		// Token: 0x0602C65A RID: 181850 RVA: 0x00C7B588 File Offset: 0x00C79788
		public override float GetShowScale()
		{
			return (float)(this.MarkConfig.Value.ShowRange(0) + this.MarkConfig.Value.ShowRange(1) / 2);
		}

		// Token: 0x04017E13 RID: 97811
		public readonly DynamicMapMark? MarkConfig;

		// Token: 0x04017E17 RID: 97815
		protected bool ConditionShouldShow = true;
	}
}
