using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E49 RID: 7753
internal class WeaponHandBookLayoutItem : UiPanelBase
{
	// Token: 0x0600EBC4 RID: 60356 RVA: 0x0037F2A2 File Offset: 0x0037D4A2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout))
		};
	}

	// Token: 0x0600EBC5 RID: 60357 RVA: 0x0037F2C5 File Offset: 0x0037D4C5
	protected override void OnStart()
	{
		this.GridLayout = new GenericLayout<WeaponHandBookWeaponItem, WeaponHandBookDynamicLayoutItemData>(base.GetGridLayout(0), new Func<WeaponHandBookWeaponItem>(this.InitItem), null, false, true);
	}

	// Token: 0x0600EBC6 RID: 60358 RVA: 0x0037F2E8 File Offset: 0x0037D4E8
	[NullableContext(1)]
	private WeaponHandBookWeaponItem InitItem()
	{
		return new WeaponHandBookWeaponItem
		{
			OnClickCallBack = this.OnClickCallBack
		};
	}

	// Token: 0x0600EBC7 RID: 60359 RVA: 0x0037F2FB File Offset: 0x0037D4FB
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

	// Token: 0x04006D52 RID: 27986
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickCallBack;

	// Token: 0x04006D53 RID: 27987
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeaponHandBookWeaponItem, WeaponHandBookDynamicLayoutItemData> GridLayout;

	// Token: 0x020083FB RID: 33787
	private class EWeaponHandBookLayoutItemDefine
	{
		// Token: 0x0402AF62 RID: 175970
		public const int Layout = 0;

		// Token: 0x0402AF63 RID: 175971
		public const int Item = 1;
	}
}
