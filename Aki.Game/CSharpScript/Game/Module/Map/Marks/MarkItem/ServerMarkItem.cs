using System;
using System.Linq;
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
	// Token: 0x020054F5 RID: 21749
	[NullableContext(1)]
	[Nullable(0)]
	public class ServerMarkItem : MarkItem
	{
		// Token: 0x17008574 RID: 34164
		// (get) Token: 0x060378E4 RID: 227556 RVA: 0x00D30AAC File Offset: 0x00D2ECAC
		// (set) Token: 0x060378E5 RID: 227557 RVA: 0x00D30ADB File Offset: 0x00D2ECDB
		public override int MarkId
		{
			get
			{
				DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
				return ((serverMarkInfo != null) ? serverMarkInfo.MarkId : null).GetValueOrDefault();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17008575 RID: 34165
		// (get) Token: 0x060378E6 RID: 227558 RVA: 0x00D30AE2 File Offset: 0x00D2ECE2
		public override EMarkType MarkType
		{
			get
			{
				DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
				if (serverMarkInfo == null)
				{
					return EMarkType.None;
				}
				return serverMarkInfo.MarkType;
			}
		}

		// Token: 0x17008576 RID: 34166
		// (get) Token: 0x060378E7 RID: 227559 RVA: 0x00D30AF5 File Offset: 0x00D2ECF5
		public int ConfigId
		{
			get
			{
				return this.ServerMarkInfo.MarkConfigId;
			}
		}

		// Token: 0x17008577 RID: 34167
		// (get) Token: 0x060378E8 RID: 227560 RVA: 0x00D30B02 File Offset: 0x00D2ED02
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

		// Token: 0x17008578 RID: 34168
		// (get) Token: 0x060378E9 RID: 227561 RVA: 0x00D30B40 File Offset: 0x00D2ED40
		public int EntityConfigId
		{
			get
			{
				return this.ServerMarkInfo.EntityConfigId.GetValueOrDefault();
			}
		}

		// Token: 0x17008579 RID: 34169
		// (get) Token: 0x060378EA RID: 227562 RVA: 0x00D30B60 File Offset: 0x00D2ED60
		public int RawInstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId.GetValueOrDefault();
			}
		}

		// Token: 0x060378EB RID: 227563 RVA: 0x00D30B80 File Offset: 0x00D2ED80
		public override bool IsMultiMap()
		{
			return this.GetMultiMapId() != 0;
		}

		// Token: 0x1700857A RID: 34170
		// (get) Token: 0x060378EC RID: 227564 RVA: 0x00D30B8B File Offset: 0x00D2ED8B
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

		// Token: 0x060378ED RID: 227565 RVA: 0x00D30BBC File Offset: 0x00D2EDBC
		public override int GetMultiMapId()
		{
			if (this.EntityConfigId == 0)
			{
				return 0;
			}
			return this.GetMultiMapIdSub();
		}

		// Token: 0x060378EE RID: 227566 RVA: 0x00D30BD0 File Offset: 0x00D2EDD0
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

		// Token: 0x1700857B RID: 34171
		// (get) Token: 0x060378EF RID: 227567 RVA: 0x00D30CAC File Offset: 0x00D2EEAC
		public bool IsServerDisable
		{
			get
			{
				return this.ServerMarkInfo.ServerMarkState == MarkState.MarkDisable;
			}
		}

		// Token: 0x1700857C RID: 34172
		// (get) Token: 0x060378F0 RID: 227568 RVA: 0x00D30CBC File Offset: 0x00D2EEBC
		public override int MapId
		{
			get
			{
				return this.ServerMarkInfo.MapId;
			}
		}

		// Token: 0x1700857D RID: 34173
		// (get) Token: 0x060378F1 RID: 227569 RVA: 0x00D30CC9 File Offset: 0x00D2EEC9
		public override int? InstanceDungeonId
		{
			get
			{
				return this.ServerMarkInfo.InstanceDungeonId;
			}
		}

		// Token: 0x060378F2 RID: 227570 RVA: 0x00D30CD8 File Offset: 0x00D2EED8
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

		// Token: 0x060378F3 RID: 227571 RVA: 0x00D30D51 File Offset: 0x00D2EF51
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.ServerMarkItemView;
		}

		// Token: 0x060378F4 RID: 227572 RVA: 0x00D30D55 File Offset: 0x00D2EF55
		protected override MarkItemView CreateView()
		{
			return new ServerMarkItemView(this);
		}

		// Token: 0x060378F5 RID: 227573 RVA: 0x00D30D60 File Offset: 0x00D2EF60
		protected bool CheckInShowRange(float scale)
		{
			return base.MapType != EMapType.WorldMap || base.IsIgnoreScaleShow || Math.Abs(this.MinShowScale - this.MaxShowScale) < 1E-08f || (this.MinShowScale < scale && this.MaxShowScale > scale);
		}

		// Token: 0x060378F6 RID: 227574 RVA: 0x00D30DB4 File Offset: 0x00D2EFB4
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

		// Token: 0x060378F7 RID: 227575 RVA: 0x00D30E74 File Offset: 0x00D2F074
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

		// Token: 0x060378F8 RID: 227576 RVA: 0x00D30EBC File Offset: 0x00D2F0BC
		public string GetAreaText()
		{
			MapMark? mapMark;
			string[] array = ((MapConfig.Instance.GetConfigMark(this.ConfigId) != null) ? mapMark.GetValueOrDefault().AreaShowText() : null) ?? Array.Empty<string>();
			if (array.Length != 0)
			{
				return string.Join("-", from item in array
				select MapConfig.Instance.GetLocalText(item));
			}
			return MapModel.Instance.GetMarkAreaText(this.MapId, this.EntityConfigId);
		}

		// Token: 0x0401D3CF RID: 119759
		protected float MinShowScale;

		// Token: 0x0401D3D0 RID: 119760
		protected float MaxShowScale;

		// Token: 0x0401D3D1 RID: 119761
		protected readonly DynamicMarkCreateInfo ServerMarkInfo;

		// Token: 0x0401D3D2 RID: 119762
		private int? MultiMapIdInternal;
	}
}
