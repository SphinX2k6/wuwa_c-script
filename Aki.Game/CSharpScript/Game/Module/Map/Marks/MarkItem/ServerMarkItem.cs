using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044C8 RID: 17608
	[NullableContext(1)]
	[Nullable(0)]
	public class ServerMarkItem : MarkItem
	{
		// Token: 0x1700590E RID: 22798
		// (get) Token: 0x0602C7B0 RID: 182192 RVA: 0x00C7E9D8 File Offset: 0x00C7CBD8
		// (set) Token: 0x0602C7B1 RID: 182193 RVA: 0x00C7E9F8 File Offset: 0x00C7CBF8
		public override int MarkId
		{
			get
			{
				return this.ServerMarkInfo.MarkId.GetValueOrDefault();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700590F RID: 22799
		// (get) Token: 0x0602C7B2 RID: 182194 RVA: 0x00C7E9FF File Offset: 0x00C7CBFF
		public override EMarkType MarkType
		{
			get
			{
				return this.ServerMarkInfo.MarkType;
			}
		}

		// Token: 0x17005910 RID: 22800
		// (get) Token: 0x0602C7B3 RID: 182195 RVA: 0x00C7EA0C File Offset: 0x00C7CC0C
		public int ConfigId
		{
			get
			{
				return this.ServerMarkInfo.MarkConfigId;
			}
		}

		// Token: 0x17005911 RID: 22801
		// (get) Token: 0x0602C7B4 RID: 182196 RVA: 0x00C7EA19 File Offset: 0x00C7CC19
		public TTrackTarget TrackPosition
		{
			get
			{
				if (!(this.ServerMarkInfo.TrackTarget is TTrackTarget_Vector) && !(this.ServerMarkInfo.TrackTarget is TTrackTarget_Vector2D))
				{
					return new TTrackTarget_Vector(new global::Vector());
				}
				return this.ServerMarkInfo.TrackTarget;
			}
		}

		// Token: 0x17005912 RID: 22802
		// (get) Token: 0x0602C7B5 RID: 182197 RVA: 0x00C7EA58 File Offset: 0x00C7CC58
		public int EntityConfigId
		{
			get
			{
				return this.ServerMarkInfo.EntityConfigId.GetValueOrDefault();
			}
		}

		// Token: 0x17005913 RID: 22803
		// (get) Token: 0x0602C7B6 RID: 182198 RVA: 0x00C7EA78 File Offset: 0x00C7CC78
		public int RawInstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId.GetValueOrDefault();
			}
		}

		// Token: 0x0602C7B7 RID: 182199 RVA: 0x00C7EA98 File Offset: 0x00C7CC98
		public override bool IsMarkDisabled()
		{
			return MapModel.Instance.IsMarkHideByServer(this.MapId, this.EntityConfigId);
		}

		// Token: 0x0602C7B8 RID: 182200 RVA: 0x00C7EAB0 File Offset: 0x00C7CCB0
		public override bool IsMultiMap()
		{
			return this.GetMultiMapId() != 0;
		}

		// Token: 0x17005914 RID: 22804
		// (get) Token: 0x0602C7B9 RID: 182201 RVA: 0x00C7EABB File Offset: 0x00C7CCBB
		public override int? TrackAreaId
		{
			get
			{
				if (this.EntityConfigId == 0)
				{
					return new int?(0);
				}
				return new int?(WorldMapModel.Instance.GetEntityAreaId(this.EntityConfigId, new int?(this.MapId)));
			}
		}

		// Token: 0x0602C7BA RID: 182202 RVA: 0x00C7EAEC File Offset: 0x00C7CCEC
		public override int GetMultiMapId()
		{
			if (this.EntityConfigId == 0)
			{
				return 0;
			}
			return this.GetMultiMapIdSub();
		}

		// Token: 0x0602C7BB RID: 182203 RVA: 0x00C7EB00 File Offset: 0x00C7CD00
		protected int GetMultiMapIdSub()
		{
			if (this.MultiMapIdInternal != null)
			{
				return this.MultiMapIdInternal.Value;
			}
			int valueOrDefault = this.TrackAreaId.GetValueOrDefault();
			int levelOneAreaId = AreaConfig.Instance.GetLevelOneAreaId(valueOrDefault);
			foreach (MultiMap multiMap in MapConfig.Instance.GetAllSubMapConfig())
			{
				if (multiMap.GetAreaBytes().Contains(levelOneAreaId) || multiMap.GetAreaBytes().Contains(valueOrDefault))
				{
					this.MultiMapIdInternal = new int?(multiMap.Id);
					break;
				}
			}
			if (this.MultiMapIdInternal == null)
			{
				this.MultiMapIdInternal = new int?(0);
			}
			return this.MultiMapIdInternal.Value;
		}

		// Token: 0x17005915 RID: 22805
		// (get) Token: 0x0602C7BC RID: 182204 RVA: 0x00C7EBDC File Offset: 0x00C7CDDC
		public bool IsServerDisable
		{
			get
			{
				return this.ServerMarkInfo.ServerMarkState == MarkState.MarkDisable;
			}
		}

		// Token: 0x17005916 RID: 22806
		// (get) Token: 0x0602C7BD RID: 182205 RVA: 0x00C7EBEC File Offset: 0x00C7CDEC
		public override int MapId
		{
			get
			{
				return this.ServerMarkInfo.MapId;
			}
		}

		// Token: 0x17005917 RID: 22807
		// (get) Token: 0x0602C7BE RID: 182206 RVA: 0x00C7EBF9 File Offset: 0x00C7CDF9
		public override EMapGravityDirection Gravity
		{
			get
			{
				return this.ServerMarkInfo.MapGravity;
			}
		}

		// Token: 0x17005918 RID: 22808
		// (get) Token: 0x0602C7BF RID: 182207 RVA: 0x00C7EC06 File Offset: 0x00C7CE06
		public override int? InstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId;
			}
		}

		// Token: 0x0602C7C0 RID: 182208 RVA: 0x00C7EC14 File Offset: 0x00C7CE14
		public ServerMarkItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(parent, mapType, markScale, markPointInfo.TrackSource.GetValueOrDefault(ETrackSource.MapMark))
		{
			this.ServerMarkInfo = markPointInfo;
			if (MapDefine.ServerMarkIgnoreReadConfigSet.Contains(markPointInfo.MarkType))
			{
				base.ShowPriority = 0;
				return;
			}
			MapMark? configMark = MapConfig.Instance.GetConfigMark(markPointInfo.MarkConfigId);
			base.ShowPriority = ((configMark != null) ? configMark.GetValueOrDefault().ShowPriority : 0);
		}

		// Token: 0x0602C7C1 RID: 182209 RVA: 0x00C7EC8D File Offset: 0x00C7CE8D
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.ServerMarkItemView;
		}

		// Token: 0x0602C7C2 RID: 182210 RVA: 0x00C7EC91 File Offset: 0x00C7CE91
		protected override MarkItemView CreateView()
		{
			return new ServerMarkItemView(this);
		}

		// Token: 0x0602C7C3 RID: 182211 RVA: 0x00C7EC9C File Offset: 0x00C7CE9C
		protected bool CheckInShowRange(float scale)
		{
			return base.MapType != EMapType.WorldMap || base.IsIgnoreScaleShow || Math.Abs(this.MinShowScale - this.MaxShowScale) < 1E-08f || (this.MinShowScale < scale && this.MaxShowScale > scale);
		}

		// Token: 0x0602C7C4 RID: 182212 RVA: 0x00C7ECF0 File Offset: 0x00C7CEF0
		[NullableContext(2)]
		protected virtual void OnAfterSetConfigId(IMarkItemData markData)
		{
			if (markData != null)
			{
				int[] showRange = markData.ShowRange;
				if (showRange != null && showRange.Length >= 2)
				{
					this.MinShowScale = (float)showRange[0];
					this.MaxShowScale = (float)showRange[1];
				}
				this.IconPath = markData.MarkPic;
				MarkItemView view = base.View;
				if (view != null)
				{
					view.OnIconPathChanged(this.IconPath);
				}
				if (markData.ShowPriority != null && markData.ShowPriority.Value != 0)
				{
					base.ShowPriority = markData.ShowPriority.Value;
				}
				base.ConfigScale = markData.Scale.GetValueOrDefault(1f);
				base.CornerScale = markData.CornerScale.GetValueOrDefault(1f);
			}
		}

		// Token: 0x0602C7C5 RID: 182213 RVA: 0x00C7EDB0 File Offset: 0x00C7CFB0
		public override bool CheckCanShowView()
		{
			float currentMapShowScale = this.GetCurrentMapShowScale();
			bool flag = this.CheckInShowRange(currentMapShowScale) || base.IsTracked;
			if (base.IsCanShowViewIntermediately != flag)
			{
				base.NeedPlayShowOrHideSeq = (flag ? "ShowView" : "HideView");
			}
			return flag;
		}

		// Token: 0x0602C7C6 RID: 182214 RVA: 0x00C7EDF8 File Offset: 0x00C7CFF8
		public string GetAreaText()
		{
			MapMark? mapMark;
			string[] array = ((MapConfig.Instance.GetConfigMark(this.ConfigId) != null) ? mapMark.GetValueOrDefault().AreaShowText() : null) ?? Array.Empty<string>();
			if (array.Length != 0)
			{
				List<string> list = new List<string>();
				foreach (string textKey in array)
				{
					list.Add(MapConfig.Instance.GetLocalText(textKey));
				}
				return string.Join("-", list);
			}
			return MapModel.Instance.GetMarkAreaText(this.MapId, this.EntityConfigId);
		}

		// Token: 0x04017E58 RID: 97880
		protected float MinShowScale;

		// Token: 0x04017E59 RID: 97881
		protected float MaxShowScale;

		// Token: 0x04017E5A RID: 97882
		protected readonly DynamicMarkCreateInfo ServerMarkInfo;

		// Token: 0x04017E5B RID: 97883
		private int? MultiMapIdInternal;
	}
}
