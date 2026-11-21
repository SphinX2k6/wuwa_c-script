using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DC9 RID: 15817
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueInfoViewTokenDetailGrid : LoopScrollMediumItemGrid<RogueGainEntry>
	{
		// Token: 0x060286C2 RID: 165570 RVA: 0x00B5352A File Offset: 0x00B5172A
		protected override void OnStart()
		{
			base.SetUseFixedAsync(true);
			base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnStageChanged));
		}

		// Token: 0x060286C3 RID: 165571 RVA: 0x00B53548 File Offset: 0x00B51748
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

		// Token: 0x060286C4 RID: 165572 RVA: 0x00B536CE File Offset: 0x00B518CE
		public void OnStageChanged(MediumItemGridExtendCallback callbackParameter)
		{
			if (callbackParameter.State == EToggleState.ETT_Checked)
			{
				this.OnSelected(true);
			}
		}

		// Token: 0x060286C5 RID: 165573 RVA: 0x00B536E0 File Offset: 0x00B518E0
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

		// Token: 0x060286C6 RID: 165574 RVA: 0x00B53712 File Offset: 0x00B51912
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x04015F2F RID: 89903
		[Nullable(2)]
		public RogueGainEntry GridData;
	}
}
