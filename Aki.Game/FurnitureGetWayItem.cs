using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000488 RID: 1160
[NullableContext(2)]
[Nullable(0)]
public class FurnitureGetWayItem : UiPanelBase
{
	// Token: 0x06003B9E RID: 15262 RVA: 0x00153308 File Offset: 0x00151508
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

	// Token: 0x06003B9F RID: 15263 RVA: 0x00153420 File Offset: 0x00151620
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureGetWayItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureGetWayItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003BA0 RID: 15264 RVA: 0x00153463 File Offset: 0x00151663
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

	// Token: 0x06003BA1 RID: 15265 RVA: 0x00153490 File Offset: 0x00151690
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

	// Token: 0x06003BA2 RID: 15266 RVA: 0x001535C0 File Offset: 0x001517C0
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

	// Token: 0x06003BA3 RID: 15267 RVA: 0x00153674 File Offset: 0x00151874
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

	// Token: 0x06003BA4 RID: 15268 RVA: 0x001536E4 File Offset: 0x001518E4
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

	// Token: 0x06003BA5 RID: 15269 RVA: 0x00153748 File Offset: 0x00151948
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

	// Token: 0x06003BA6 RID: 15270 RVA: 0x001537AA File Offset: 0x001519AA
	public void RefreshAtmosphereItem()
	{
		IFurnitureGetWayViewData data = this.Data;
		if (data == null || data.LockReason != EFurnitureLockReason.Atmosphere)
		{
			return;
		}
		this.RefreshLockReasonText();
	}

	// Token: 0x06003BA7 RID: 15271 RVA: 0x001537D0 File Offset: 0x001519D0
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

	// Token: 0x06003BA8 RID: 15272 RVA: 0x0015384A File Offset: 0x00151A4A
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

	// Token: 0x04003012 RID: 12306
	private IFurnitureGetWayViewData Data;

	// Token: 0x04003013 RID: 12307
	private FurnitureGetWayButtonItem OccupiedItem;

	// Token: 0x04003014 RID: 12308
	private FurnitureGetWayButtonItem ShopItem;

	// Token: 0x04003015 RID: 12309
	private FurnitureGetWayButtonItem GiftItem;
}
