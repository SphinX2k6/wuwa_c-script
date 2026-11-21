using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002251 RID: 8785
public class WeaponResonanceItem : UiPanelBase
{
	// Token: 0x06015B71 RID: 88945 RVA: 0x0064C5F6 File Offset: 0x0064A7F6
	[NullableContext(1)]
	public WeaponResonanceItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06015B72 RID: 88946 RVA: 0x0064C60C File Offset: 0x0064A80C
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

	// Token: 0x06015B73 RID: 88947 RVA: 0x0064C6D8 File Offset: 0x0064A8D8
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

	// Token: 0x020084B5 RID: 33973
	private enum EWeaponResonanceItemDefine
	{
		// Token: 0x0402ACB1 RID: 175281
		FromText,
		// Token: 0x0402ACB2 RID: 175282
		DescribeText,
		// Token: 0x0402ACB3 RID: 175283
		LevelText,
		// Token: 0x0402ACB4 RID: 175284
		SkillText,
		// Token: 0x0402ACB5 RID: 175285
		WeaponSprite
	}
}
