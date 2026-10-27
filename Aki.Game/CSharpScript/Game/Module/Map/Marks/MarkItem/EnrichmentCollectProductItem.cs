using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054E1 RID: 21729
	[NullableContext(1)]
	[Nullable(0)]
	public class EnrichmentCollectProductItem : ServerMarkItem
	{
		// Token: 0x17008538 RID: 34104
		// (get) Token: 0x060377B4 RID: 227252 RVA: 0x00D2D96B File Offset: 0x00D2BB6B
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.EnrichmentCollectProduct;
			}
		}

		// Token: 0x060377B5 RID: 227253 RVA: 0x00D2D96F File Offset: 0x00D2BB6F
		public EnrichmentCollectProductItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x060377B6 RID: 227254 RVA: 0x00D2D97C File Offset: 0x00D2BB7C
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.EnrichmentCollectProductItemView;
		}

		// Token: 0x060377B7 RID: 227255 RVA: 0x00D2D97F File Offset: 0x00D2BB7F
		protected override MarkItemView CreateView()
		{
			return new EnrichmentCollectProductItemView(this);
		}

		// Token: 0x060377B8 RID: 227256 RVA: 0x00D2D988 File Offset: 0x00D2BB88
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			int configId = 6;
			this.SetConfigId(configId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x060377B9 RID: 227257 RVA: 0x00D2D9BD File Offset: 0x00D2BBBD
		public void SetConfigId(int configId)
		{
			this.OnSetConfigId(configId);
		}

		// Token: 0x060377BA RID: 227258 RVA: 0x00D2D9C8 File Offset: 0x00D2BBC8
		public void OnSetConfigId(int configId)
		{
			MapMark value = MapConfig.Instance.GetConfigMark(configId).Value;
			this.OnAfterSetConfigId(new MarkItemData
			{
				ShowRange = value.ShowRange(),
				MarkPic = value.UnlockMarkPic,
				ShowPriority = new int?(value.ShowPriority),
				Scale = new float?(value.Scale),
				CornerScale = new float?(value.CornerScale)
			});
		}

		// Token: 0x060377BB RID: 227259 RVA: 0x00D2DA44 File Offset: 0x00D2BC44
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
