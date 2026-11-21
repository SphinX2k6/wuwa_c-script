using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200130B RID: 4875
internal class WeaponHandBookLayoutItem : UiPanelBase
{
	// Token: 0x0600BFE3 RID: 49123 RVA: 0x0038AF32 File Offset: 0x00389132
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600BFE4 RID: 49124 RVA: 0x0038AF55 File Offset: 0x00389155
	protected override void OnStart()
	{
		this.GridLayout = new GenericLayout<WeaponHandBookWeaponItem, WeaponHandBookDynamicLayoutItemData>(base.GetGridLayout(0), new Func<WeaponHandBookWeaponItem>(this.InitItem), null, false, true);
	}

	// Token: 0x0600BFE5 RID: 49125 RVA: 0x0038AF78 File Offset: 0x00389178
	[NullableContext(1)]
	private WeaponHandBookWeaponItem InitItem()
	{
		return new WeaponHandBookWeaponItem
		{
			OnClickCallBack = this.OnClickCallBack
		};
	}

	// Token: 0x0600BFE6 RID: 49126 RVA: 0x0038AF8B File Offset: 0x0038918B
	[NullableContext(1)]
	public void Update(List<WeaponHandBookDynamicLayoutItemData> dataList)
	{
		GenericLayout<WeaponHandBookWeaponItem, WeaponHandBookDynamicLayoutItemData> gridLayout = this.GridLayout;
		if (gridLayout == null)
		{
			return;
		}
		gridLayout.RefreshByData(dataList, delegate
		{
			GenericLayout<WeaponHandBookWeaponItem, WeaponHandBookDynamicLayoutItemData> gridLayout2 = this.GridLayout;
			foreach (WeaponHandBookWeaponItem weaponHandBookWeaponItem in (((gridLayout2 != null) ? gridLayout2.GetLayoutItemList() : null) ?? new List<WeaponHandBookWeaponItem>()))
			{
				if (weaponHandBookWeaponItem.HandBookId == HandBookModel.Instance.CurrentSelectWeaponHandBookId)
				{
					weaponHandBookWeaponItem.OnSelected(true);
					break;
				}
			}
		}, false);
	}

	// Token: 0x04006E33 RID: 28211
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickCallBack;

	// Token: 0x04006E34 RID: 28212
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeaponHandBookWeaponItem, WeaponHandBookDynamicLayoutItemData> GridLayout;

	// Token: 0x02007580 RID: 30080
	private class EWeaponHandBookLayoutItemDefine
	{
		// Token: 0x04026286 RID: 156294
		public const int Layout = 0;

		// Token: 0x04026287 RID: 156295
		public const int Item = 1;
	}
}
