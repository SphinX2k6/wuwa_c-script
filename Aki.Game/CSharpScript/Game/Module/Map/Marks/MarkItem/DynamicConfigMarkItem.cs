using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054DE RID: 21726
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicConfigMarkItem : MarkItem
	{
		// Token: 0x1700852B RID: 34091
		// (get) Token: 0x0603778A RID: 227210 RVA: 0x00D2CFC8 File Offset: 0x00D2B1C8
		public bool IsFogUnlock
		{
			get
			{
				DynamicMapMark value = this.MarkConfig.Value;
				return value.FogShow == 1 || MapModel.Instance.CheckFogUnlocked(value.FogHide, null);
			}
		}

		// Token: 0x1700852C RID: 34092
		// (get) Token: 0x0603778B RID: 227211 RVA: 0x00D2D007 File Offset: 0x00D2B207
		// (set) Token: 0x0603778C RID: 227212 RVA: 0x00D2D00F File Offset: 0x00D2B20F
		public override int MarkId { get; set; }

		// Token: 0x1700852D RID: 34093
		// (get) Token: 0x0603778D RID: 227213 RVA: 0x00D2D018 File Offset: 0x00D2B218
		public int MarkConfigId
		{
			get
			{
				return this.MarkConfig.Value.MarkId;
			}
		}

		// Token: 0x1700852E RID: 34094
		// (get) Token: 0x0603778E RID: 227214 RVA: 0x00D2D038 File Offset: 0x00D2B238
		public override EMarkType MarkType
		{
			get
			{
				return (EMarkType)this.MarkConfig.Value.ObjectType;
			}
		}

		// Token: 0x1700852F RID: 34095
		// (get) Token: 0x06037790 RID: 227216 RVA: 0x00D2D061 File Offset: 0x00D2B261
		// (set) Token: 0x0603778F RID: 227215 RVA: 0x00D2D058 File Offset: 0x00D2B258
		public int? OverrideMapId { get; set; }

		// Token: 0x17008530 RID: 34096
		// (get) Token: 0x06037791 RID: 227217 RVA: 0x00D2D06C File Offset: 0x00D2B26C
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

		// Token: 0x17008531 RID: 34097
		// (get) Token: 0x06037792 RID: 227218 RVA: 0x00D2D0A4 File Offset: 0x00D2B2A4
		public override int? InstanceDungeonId
		{
			get
			{
				return new int?(this.MarkConfig.Value.InstanceDungeonId);
			}
		}

		// Token: 0x06037793 RID: 227219 RVA: 0x00D2D0CC File Offset: 0x00D2B2CC
		public DynamicConfigMarkItem(int markId, DynamicMapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(parent, mapType, markScale, trackSource)
		{
			this.MarkId = markId;
			base.ShowPriority = markConfig.ShowPriority;
			this.MarkConfig = new DynamicMapMark?(markConfig);
			this.IconPath = this.MarkConfig.Value.LockMarkPic;
		}

		// Token: 0x06037794 RID: 227220 RVA: 0x00D2D128 File Offset: 0x00D2B328
		protected override void OnInitialize()
		{
			if (this.MarkConfig != null && this.MarkConfig.Value.Scale != 0f)
			{
				base.SetConfigScale(this.MarkConfig.Value.Scale);
			}
			this.InitPosition(this.MarkConfig.Value);
			this.InitShowCondition();
		}

		// Token: 0x06037795 RID: 227221 RVA: 0x00D2D18C File Offset: 0x00D2B38C
		protected void InitPosition(DynamicMapMark markConfig)
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

		// Token: 0x06037796 RID: 227222 RVA: 0x00D2D22B File Offset: 0x00D2B42B
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.DynamicConfigMarkItemView;
		}

		// Token: 0x06037797 RID: 227223 RVA: 0x00D2D22E File Offset: 0x00D2B42E
		[PreserveBaseOverrides]
		protected new virtual DynamicConfigMarkItemView CreateView()
		{
			return new DynamicConfigMarkItemView(this);
		}

		// Token: 0x06037798 RID: 227224 RVA: 0x00D2D238 File Offset: 0x00D2B438
		public override string GetLocaleDesc()
		{
			return this.MarkConfig.Value.MarkDesc;
		}

		// Token: 0x06037799 RID: 227225 RVA: 0x00D2D258 File Offset: 0x00D2B458
		public override string GetTitleText()
		{
			return MapConfig.Instance.GetLocalText(this.MarkConfig.Value.MarkTitle);
		}

		// Token: 0x17008532 RID: 34098
		// (get) Token: 0x0603779A RID: 227226 RVA: 0x00D2D284 File Offset: 0x00D2B484
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

		// Token: 0x0603779B RID: 227227 RVA: 0x00D2D2F4 File Offset: 0x00D2B4F4
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
				return string.Join("-", from item in array
				select MapConfig.Instance.GetLocalText(item));
			}
			return MapModel.Instance.GetMarkAreaText(this.MapId, base.TrackTarget as TTrackTarget_Int);
		}

		// Token: 0x0603779C RID: 227228 RVA: 0x00D2D3C0 File Offset: 0x00D2B5C0
		private bool CheckInShowRange(float scale)
		{
			DynamicMapMark value = this.MarkConfig.Value;
			return (float)value.ShowRange(0) < scale && (float)value.ShowRange(1) > scale;
		}

		// Token: 0x0603779D RID: 227229 RVA: 0x00D2D3F3 File Offset: 0x00D2B5F3
		protected void InitShowCondition()
		{
			this.ConditionShouldShow = true;
		}

		// Token: 0x0603779E RID: 227230 RVA: 0x00D2D3FC File Offset: 0x00D2B5FC
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

		// Token: 0x0603779F RID: 227231 RVA: 0x00D2D49C File Offset: 0x00D2B69C
		public override float GetShowScale()
		{
			return (float)(this.MarkConfig.Value.ShowRange(0) + this.MarkConfig.Value.ShowRange(1) / 2);
		}

		// Token: 0x0401D398 RID: 119704
		public readonly DynamicMapMark? MarkConfig;

		// Token: 0x0401D39B RID: 119707
		protected bool ConditionShouldShow = true;
	}
}
