using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002CF7 RID: 11511
public class WeaponResonanceItem : UiPanelBase
{
	// Token: 0x060182D0 RID: 99024 RVA: 0x0062662E File Offset: 0x0062482E
	[NullableContext(1)]
	public WeaponResonanceItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060182D1 RID: 99025 RVA: 0x00626644 File Offset: 0x00624844
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060182D2 RID: 99026 RVA: 0x00626710 File Offset: 0x00624910
	[NullableContext(1)]
	public void UpdateItem(WeaponDataBase data)
	{
		WeaponConf? weaponConfig = data.GetWeaponConfig();
		LguiUtil.Instance.SetLocalText(base.GetText(2), "WeaponResonanceItemLevelText", new <>z__ReadOnlySingleElementList<object>(data.GetResonanceLevel()));
		WeaponReson? weaponResonanceConfig = WeaponConfig.Instance.GetWeaponResonanceConfig(weaponConfig.Value.ResonId, data.GetResonanceLevel());
		base.GetText(1).SetUIActive(weaponResonanceConfig != null);
		base.GetText(3).SetUIActive(weaponResonanceConfig != null);
		if (weaponResonanceConfig != null)
		{
			base.GetText(3).SetText(WeaponConfig.Instance.GetWeaponResonanceDesc(weaponResonanceConfig.Value.Name), true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.GetItemConfig().BgDescription, Array.Empty<object>());
		string[] weaponConfigDescParams = WeaponModel.Instance.GetWeaponConfigDescParams(weaponConfig.Value, data.GetResonanceLevel());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), weaponConfig.Value.Desc, weaponConfigDescParams);
		int weaponType = weaponConfig.Value.WeaponType;
		foreach (Mapping mapping in MappingConfig.Instance.GetWeaponConfList())
		{
			if (weaponType == mapping.Value)
			{
				this.SetSpriteByPath(mapping.Icon, base.GetSprite(4), false, null, null);
				break;
			}
		}
	}

	// Token: 0x0200928D RID: 37517
	private enum EWeaponResonanceItemDefine
	{
		// Token: 0x0402F627 RID: 194087
		FromText,
		// Token: 0x0402F628 RID: 194088
		DescribeText,
		// Token: 0x0402F629 RID: 194089
		LevelText,
		// Token: 0x0402F62A RID: 194090
		SkillText,
		// Token: 0x0402F62B RID: 194091
		WeaponSprite
	}
}
