using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020029F9 RID: 10745
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShopItemNew : GridProxyAbstract<ShopItemFullInfo>
{
	// Token: 0x060164A8 RID: 91304 RVA: 0x005A42B8 File Offset: 0x005A24B8
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

	// Token: 0x060164A9 RID: 91305 RVA: 0x005A4390 File Offset: 0x005A2590
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

	// Token: 0x060164AA RID: 91306 RVA: 0x005A4450 File Offset: 0x005A2650
	private void ButtonClick(EToggleState toggleState)
	{
		ShopModel.Instance.OpenItemInfo = this.ItemInfo;
		EventSystem.Instance.Emit(EEventName.OpenItemInfo);
	}

	// Token: 0x060164AB RID: 91307 RVA: 0x005A4472 File Offset: 0x005A2672
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.ButtonClick(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x060164AC RID: 91308 RVA: 0x005A447E File Offset: 0x005A267E
	public override void Refresh(ShopItemFullInfo data, bool isSelected, int gridIndex)
	{
		this.UpdateItem(data);
	}

	// Token: 0x0400A5DC RID: 42460
	[Nullable(2)]
	public ShopItemFullInfo ItemInfo;

	// Token: 0x02009031 RID: 36913
	[NullableContext(0)]
	private enum EShopItemNewDefine
	{
		// Token: 0x0402EB0E RID: 191246
		QualitySprite,
		// Token: 0x0402EB0F RID: 191247
		TextureIcon,
		// Token: 0x0402EB10 RID: 191248
		TxtName,
		// Token: 0x0402EB11 RID: 191249
		PanelName,
		// Token: 0x0402EB12 RID: 191250
		Toggle,
		// Token: 0x0402EB13 RID: 191251
		SoldOutSprite = 10,
		// Token: 0x0402EB14 RID: 191252
		LockSprite
	}
}
