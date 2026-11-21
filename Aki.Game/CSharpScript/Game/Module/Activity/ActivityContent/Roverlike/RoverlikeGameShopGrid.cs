using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050D5 RID: 20693
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeGameShopGrid : LoopScrollMediumItemGrid<IRoverlikeGameShopGridData>
	{
		// Token: 0x06033C85 RID: 212101 RVA: 0x00E7E157 File Offset: 0x00E7C357
		public void BindOnSelect(Action<IRoverlikeGameShopGridData> cb)
		{
			this.OnSelect = cb;
		}

		// Token: 0x06033C86 RID: 212102 RVA: 0x00E7E160 File Offset: 0x00E7C360
		protected override void OnStart()
		{
			base.SetUseFixedAsync(true);
		}

		// Token: 0x06033C87 RID: 212103 RVA: 0x00E7E16C File Offset: 0x00E7C36C
		protected override void OnRefresh(IRoverlikeGameShopGridData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			RoverRogueItem? itemConfig = RoverlikeConfig.Instance.GetItemConfig(data.ShowItemId);
			int gold = RoverlikeModel.Instance.Gold;
			MediumItemPrice itemPrice = new MediumItemPrice
			{
				CurPrice = data.FinalPrice,
				OriginalPrice = new int?(data.OriginalPrice),
				CurrencyNotEnough = new bool?(gold < data.FinalPrice)
			};
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				IconPath = itemConfig.Value.Icon,
				QualityId = new int?(itemConfig.Value.Quality),
				IsRogueFinish = new bool?(data.IsBought),
				ItemPrice = itemPrice
			};
			base.Apply<PropMediumItemGrid>(parameters);
			this.SetSelected(data.IsSelected, false);
			bool value = data.OriginalPrice > data.FinalPrice;
			base.RefreshComponent(typeof(RoverlikeGameShopDiscountTagComponent), new bool?(value), data);
		}

		// Token: 0x06033C88 RID: 212104 RVA: 0x00E7E266 File Offset: 0x00E7C466
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked && this.Data != null)
			{
				Action<IRoverlikeGameShopGridData> onSelect = this.OnSelect;
				if (onSelect == null)
				{
					return;
				}
				onSelect(this.Data);
			}
		}

		// Token: 0x06033C89 RID: 212105 RVA: 0x00E7E28A File Offset: 0x00E7C48A
		public override object GetKey(IRoverlikeGameShopGridData data, int gridIndex)
		{
			return data.IncId;
		}

		// Token: 0x0401B70B RID: 112395
		[Nullable(2)]
		public new IRoverlikeGameShopGridData Data;

		// Token: 0x0401B70C RID: 112396
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeGameShopGridData> OnSelect;
	}
}
