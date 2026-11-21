using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044B4 RID: 17588
	[NullableContext(1)]
	[Nullable(0)]
	public class EnrichmentCollectProductItem : ServerMarkItem
	{
		// Token: 0x170058C6 RID: 22726
		// (get) Token: 0x0602C670 RID: 181872 RVA: 0x00C7BA4F File Offset: 0x00C79C4F
		public override EMarkType MarkType
		{
			get
			{
				return EMarkType.EnrichmentCollectProduct;
			}
		}

		// Token: 0x0602C671 RID: 181873 RVA: 0x00C7BA53 File Offset: 0x00C79C53
		public EnrichmentCollectProductItem(DynamicMarkCreateInfo markPointInfo, UUIItem parent, EMapType mapType, float markScale) : base(markPointInfo, parent, mapType, markScale)
		{
		}

		// Token: 0x0602C672 RID: 181874 RVA: 0x00C7BA60 File Offset: 0x00C79C60
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.EnrichmentCollectProductItemView;
		}

		// Token: 0x0602C673 RID: 181875 RVA: 0x00C7BA63 File Offset: 0x00C79C63
		protected override MarkItemView CreateView()
		{
			return new EnrichmentCollectProductItemView(this);
		}

		// Token: 0x0602C674 RID: 181876 RVA: 0x00C7BA6C File Offset: 0x00C79C6C
		protected override void OnInitialize()
		{
			base.OnInitialize();
			DynamicMarkCreateInfo serverMarkInfo = this.ServerMarkInfo;
			base.SetTrackData(serverMarkInfo.TrackTarget);
			int configId = 6;
			this.SetConfigId(configId);
			this.UpdateVisibleRelativeState();
		}

		// Token: 0x0602C675 RID: 181877 RVA: 0x00C7BAA1 File Offset: 0x00C79CA1
		public void SetConfigId(int configId)
		{
			this.OnSetConfigId(configId);
		}

		// Token: 0x0602C676 RID: 181878 RVA: 0x00C7BAAC File Offset: 0x00C79CAC
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

		// Token: 0x0602C677 RID: 181879 RVA: 0x00C7BB28 File Offset: 0x00C79D28
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
