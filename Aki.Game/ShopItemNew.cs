using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F74 RID: 8052
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShopItemNew : GridProxyAbstract<ShopItemFullInfo>
{
	// Token: 0x06013EAF RID: 81583 RVA: 0x005CF290 File Offset: 0x005CD490
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.ButtonClick))
		};
	}

	// Token: 0x06013EB0 RID: 81584 RVA: 0x005CF368 File Offset: 0x005CD568
	public void UpdateItem(ShopItemFullInfo data)
	{
		if (data == null)
		{
			return;
		}
		this.RootItem.SetAsLastHierarchy();
		this.ItemInfo = data;
		base.SetItemQualityIcon(base.GetSprite(0), this.ItemInfo.ItemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		base.SetItemIcon(base.GetTexture(1), this.ItemInfo.ItemId, null, null);
		ItemConfig itemInfo = this.ItemInfo.ItemInfo;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), itemInfo.Name, Array.Empty<object>());
		base.GetSprite(10).SetUIActive(this.ItemInfo.IsSoldOut());
		base.GetSprite(11).SetUIActive(this.ItemInfo.IsLocked);
	}

	// Token: 0x06013EB1 RID: 81585 RVA: 0x005CF428 File Offset: 0x005CD628
	private void ButtonClick(EToggleState toggleState)
	{
		ShopModel.Instance.OpenItemInfo = this.ItemInfo;
		EventSystem.Instance.Emit(EEventName.OpenItemInfo);
	}

	// Token: 0x06013EB2 RID: 81586 RVA: 0x005CF44A File Offset: 0x005CD64A
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.ButtonClick(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x06013EB3 RID: 81587 RVA: 0x005CF456 File Offset: 0x005CD656
	public override void Refresh(ShopItemFullInfo data, bool isSelected, int gridIndex)
	{
		this.UpdateItem(data);
	}

	// Token: 0x0400A9C6 RID: 43462
	[Nullable(2)]
	public ShopItemFullInfo ItemInfo;

	// Token: 0x02008278 RID: 33400
	[NullableContext(0)]
	private enum EShopItemNewDefine
	{
		// Token: 0x0402A206 RID: 172550
		QualitySprite,
		// Token: 0x0402A207 RID: 172551
		TextureIcon,
		// Token: 0x0402A208 RID: 172552
		TxtName,
		// Token: 0x0402A209 RID: 172553
		PanelName,
		// Token: 0x0402A20A RID: 172554
		Toggle,
		// Token: 0x0402A20B RID: 172555
		SoldOutSprite = 10,
		// Token: 0x0402A20C RID: 172556
		LockSprite
	}
}
