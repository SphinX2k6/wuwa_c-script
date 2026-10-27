using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006157 RID: 24919
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeGameShopGrid : LoopScrollMediumItemGrid<IRoverlikeGameShopGridData>
	{
		// Token: 0x0603EFC5 RID: 257989 RVA: 0x00F37283 File Offset: 0x00F35483
		public void BindOnSelect(Action<IRoverlikeGameShopGridData> cb)
		{
			this.OnSelect = cb;
		}

		// Token: 0x0603EFC6 RID: 257990 RVA: 0x00F3728C File Offset: 0x00F3548C
		protected override void OnStart()
		{
			base.SetUseFixedAsync(true);
		}

		// Token: 0x0603EFC7 RID: 257991 RVA: 0x00F37298 File Offset: 0x00F35498
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

		// Token: 0x0603EFC8 RID: 257992 RVA: 0x00F37392 File Offset: 0x00F35592
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

		// Token: 0x0603EFC9 RID: 257993 RVA: 0x00F373B6 File Offset: 0x00F355B6
		public override object GetKey(IRoverlikeGameShopGridData data, int gridIndex)
		{
			return data.IncId;
		}

		// Token: 0x04020DDE RID: 134622
		[Nullable(2)]
		public new IRoverlikeGameShopGridData Data;

		// Token: 0x04020DDF RID: 134623
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeGameShopGridData> OnSelect;
	}
}
