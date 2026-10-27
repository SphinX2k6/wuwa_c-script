using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000FD3 RID: 4051
[NullableContext(2)]
[Nullable(0)]
public class FurnitureGetWayItem : UiPanelBase
{
	// Token: 0x06006806 RID: 26630 RVA: 0x0014AA44 File Offset: 0x00148C44
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnClickConfirmButton))
		};
	}

	// Token: 0x06006807 RID: 26631 RVA: 0x0014AB5C File Offset: 0x00148D5C
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureGetWayItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureGetWayItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006808 RID: 26632 RVA: 0x0014AB9F File Offset: 0x00148D9F
	[NullableContext(1)]
	public void Refresh(IFurnitureGetWayViewData data)
	{
		this.Data = data;
		this.UpdateItemsVisible();
		this.RefreshFurnitureInfo();
		this.RefreshOccupiedItem();
		this.RefreshShopItem();
		this.RefreshGiftItem();
		this.RefreshAtmosphereItem();
	}

	// Token: 0x06006809 RID: 26633 RVA: 0x0014ABCC File Offset: 0x00148DCC
	public void UpdateItemsVisible()
	{
		IFurnitureGetWayViewData data = this.Data;
		bool flag = data != null && data.LockReason == EFurnitureLockReason.Occupied;
		IFurnitureGetWayViewData data2 = this.Data;
		bool flag2 = data2 != null && data2.LockReason == EFurnitureLockReason.Shop;
		IFurnitureGetWayViewData data3 = this.Data;
		bool flag3 = data3 != null && data3.LockReason == EFurnitureLockReason.Gift;
		IFurnitureGetWayViewData data4 = this.Data;
		bool flag4 = ((data4 != null) ? data4.ConfirmFunction : null) != null;
		IFurnitureGetWayViewData data5 = this.Data;
		bool flag5 = ((data5 != null) ? data5.JumpFunction : null) != null;
		IFurnitureGetWayViewData data6 = this.Data;
		string text = (data6 != null) ? data6.LockReasonTextId : null;
		bool flag6 = text != null && !StringUtils.IsEmpty(text);
		FurnitureGetWayButtonItem occupiedItem = this.OccupiedItem;
		if (occupiedItem != null)
		{
			occupiedItem.SetUiActive(flag);
		}
		FurnitureGetWayButtonItem shopItem = this.ShopItem;
		if (shopItem != null)
		{
			shopItem.SetUiActive(flag2 && flag5 && !flag6);
		}
		FurnitureGetWayButtonItem giftItem = this.GiftItem;
		if (giftItem != null)
		{
			giftItem.SetUiActive(flag3 && flag5 && !flag6);
		}
		UUIButtonComponent button = base.GetButton(7);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag && flag4);
		}
		UUIItem item = base.GetItem(8);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!flag && flag6);
	}

	// Token: 0x0600680A RID: 26634 RVA: 0x0014ACFC File Offset: 0x00148EFC
	public void RefreshFurnitureInfo()
	{
		IFurnitureGetWayViewData data = this.Data;
		string path = ((data != null) ? data.FurnitureConfig.IconBig : null) ?? "";
		base.SetTextureShowUntilLoaded(path, base.GetTexture(0), null);
		LguiUtil instance = LguiUtil.Instance;
		UUIText text = base.GetText(2);
		IFurnitureGetWayViewData data2 = this.Data;
		instance.SetLocalTextNew(text, ((data2 != null) ? data2.FurnitureConfig.Name : null) ?? "", Array.Empty<object>());
		LguiUtil instance2 = LguiUtil.Instance;
		UUIText text2 = base.GetText(3);
		IFurnitureGetWayViewData data3 = this.Data;
		instance2.SetLocalTextNew(text2, ((data3 != null) ? data3.FurnitureConfig.AttributesDescription : null) ?? "", Array.Empty<object>());
	}

	// Token: 0x0600680B RID: 26635 RVA: 0x0014ADB0 File Offset: 0x00148FB0
	public void RefreshOccupiedItem()
	{
		IFurnitureGetWayViewData data = this.Data;
		if (data == null || data.LockReason != EFurnitureLockReason.Occupied)
		{
			return;
		}
		FurnitureGetWayButtonItem occupiedItem = this.OccupiedItem;
		if (occupiedItem == null)
		{
			return;
		}
		occupiedItem.Refresh(new FurnitureGetWayButtonItemData
		{
			NameTextId = this.Data.LockReasonTextId,
			NameTextParams = this.Data.LockReasonTextParams,
			JumpFunction = this.Data.JumpFunction
		});
	}

	// Token: 0x0600680C RID: 26636 RVA: 0x0014AE20 File Offset: 0x00149020
	public void RefreshShopItem()
	{
		IFurnitureGetWayViewData data = this.Data;
		if (data == null || data.LockReason != EFurnitureLockReason.Shop)
		{
			return;
		}
		if (this.Data.JumpFunction == null)
		{
			this.RefreshLockReasonText();
			return;
		}
		FurnitureGetWayButtonItem shopItem = this.ShopItem;
		if (shopItem == null)
		{
			return;
		}
		shopItem.Refresh(new FurnitureGetWayButtonItemData
		{
			JumpFunction = this.Data.JumpFunction
		});
	}

	// Token: 0x0600680D RID: 26637 RVA: 0x0014AE84 File Offset: 0x00149084
	public void RefreshGiftItem()
	{
		IFurnitureGetWayViewData data = this.Data;
		if (data == null || data.LockReason != EFurnitureLockReason.Gift)
		{
			return;
		}
		if (this.Data.JumpFunction == null)
		{
			this.RefreshLockReasonText();
			return;
		}
		FurnitureGetWayButtonItem giftItem = this.GiftItem;
		if (giftItem == null)
		{
			return;
		}
		giftItem.Refresh(new FurnitureGetWayButtonItemData
		{
			JumpFunction = this.Data.JumpFunction
		});
	}

	// Token: 0x0600680E RID: 26638 RVA: 0x0014AEE6 File Offset: 0x001490E6
	public void RefreshAtmosphereItem()
	{
		IFurnitureGetWayViewData data = this.Data;
		if (data == null || data.LockReason != EFurnitureLockReason.Atmosphere)
		{
			return;
		}
		this.RefreshLockReasonText();
	}

	// Token: 0x0600680F RID: 26639 RVA: 0x0014AF0C File Offset: 0x0014910C
	private void RefreshLockReasonText()
	{
		IFurnitureGetWayViewData data = this.Data;
		if (((data != null) ? data.LockReasonTextId : null) == null)
		{
			return;
		}
		if (this.Data.LockReasonTextParams != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), this.Data.LockReasonTextId, this.Data.LockReasonTextParams);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), this.Data.LockReasonTextId, Array.Empty<object>());
	}

	// Token: 0x06006810 RID: 26640 RVA: 0x0014AF86 File Offset: 0x00149186
	private void OnClickConfirmButton()
	{
		IFurnitureGetWayViewData data = this.Data;
		if (data == null)
		{
			return;
		}
		Action confirmFunction = data.ConfirmFunction;
		if (confirmFunction == null)
		{
			return;
		}
		confirmFunction();
	}

	// Token: 0x04002F79 RID: 12153
	private IFurnitureGetWayViewData Data;

	// Token: 0x04002F7A RID: 12154
	private FurnitureGetWayButtonItem OccupiedItem;

	// Token: 0x04002F7B RID: 12155
	private FurnitureGetWayButtonItem ShopItem;

	// Token: 0x04002F7C RID: 12156
	private FurnitureGetWayButtonItem GiftItem;
}
