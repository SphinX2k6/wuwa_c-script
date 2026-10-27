using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E00 RID: 19968
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueInfoViewTokenDetailGrid : LoopScrollMediumItemGrid<RogueGainEntry>
	{
		// Token: 0x06033857 RID: 211031 RVA: 0x00C0A01A File Offset: 0x00C0821A
		protected override void OnStart()
		{
			base.SetUseFixedAsync(true);
			base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnStageChanged));
		}

		// Token: 0x06033858 RID: 211032 RVA: 0x00C0A038 File Offset: 0x00C08238
		protected override void OnRefresh(RogueGainEntry data, bool isSelected, int gridIndex)
		{
			this.GridData = data;
			RogueBuffPool? rogueBuffConfig = RoguelikeConfig.Instance.GetRogueBuffConfig(data.ConfigId);
			InventoryModel instance = InventoryModel.Instance;
			int num = (instance != null) ? instance.GetItemCountByConfigId(data.ShopItemCoinId, 0) : 0;
			IMediumItemPrice itemPrice = null;
			if (data.OriginalPrice != 0)
			{
				MediumItemPrice mediumItemPrice = new MediumItemPrice();
				mediumItemPrice.CurPrice = data.CurrentPrice.Value;
				mediumItemPrice.OriginalPrice = new int?(data.OriginalPrice);
				int num2 = num;
				int? currentPrice = data.CurrentPrice;
				mediumItemPrice.CurrencyNotEnough = new bool?(num2 < currentPrice.GetValueOrDefault() & currentPrice != null);
				itemPrice = mediumItemPrice;
			}
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				IconPath = rogueBuffConfig.Value.BuffIcon,
				QualityId = new int?(rogueBuffConfig.Value.Quality),
				QualityType = new CommonDefine.EQualityIconType?(CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath),
				IsRogueFinish = data.IsSell,
				ItemPrice = itemPrice
			};
			base.Apply<PropMediumItemGrid>(parameters);
			this.SetSelected(isSelected, false);
			if (isSelected)
			{
				this.OnSelected(true);
			}
			ItemGridComponent component = base.RefreshComponent(typeof(RogueInfoViewTokenElement), new bool?(true), data);
			base.SetComponentVisible(component, data.OriginalPrice != 0);
			ItemGridComponent component2 = base.RefreshComponent(typeof(RogueInfoViewTokenDetailGridBottom), new bool?(true), data);
			base.SetComponentVisible(component2, data.OriginalPrice == 0);
			ItemGridComponent component3 = base.RefreshComponent(typeof(RogueInfoViewShopDiscountTag), new bool?(true), data);
			base.SetComponentVisible(component3, data.IsDiscounted());
		}

		// Token: 0x06033859 RID: 211033 RVA: 0x00C0A1BE File Offset: 0x00C083BE
		public void OnStageChanged(MediumItemGridExtendCallback callbackParameter)
		{
			if (callbackParameter.State == EToggleState.ETT_Checked)
			{
				this.OnSelected(true);
			}
		}

		// Token: 0x0603385A RID: 211034 RVA: 0x00C0A1D0 File Offset: 0x00C083D0
		public override void OnSelected(bool fireEvent)
		{
			if (this.IsSelected)
			{
				return;
			}
			this.SetSelected(true, fireEvent);
			if (fireEvent)
			{
				EventSystem.Instance.Emit<RogueGainEntry, int>(EEventName.RoguelikeInfoSelectedToken, this.GridData, base.GridIndex);
			}
		}

		// Token: 0x0603385B RID: 211035 RVA: 0x00C0A202 File Offset: 0x00C08402
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x0401B55C RID: 111964
		[Nullable(2)]
		public RogueGainEntry GridData;
	}
}
