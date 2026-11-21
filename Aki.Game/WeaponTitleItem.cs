using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000B60 RID: 2912
public class WeaponTitleItem : TitleItemBase<int>
{
	// Token: 0x0600795D RID: 31069 RVA: 0x0025A213 File Offset: 0x00258413
	[NullableContext(1)]
	public WeaponTitleItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600795E RID: 31070 RVA: 0x0025A21C File Offset: 0x0025841C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITextureTransitionComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600795F RID: 31071 RVA: 0x0025A288 File Offset: 0x00258488
	[NullableContext(1)]
	public override void ShowTemp(int data, DropDownItemBase<int> selectedItemObj)
	{
		UUITextureTransitionComponent uiTextureTransitionComponent = base.GetUiTextureTransitionComponent(1);
		string newText = "";
		if (data > 0)
		{
			IReadOnlyList<Mapping> weaponConfList = MappingConfig.Instance.GetWeaponConfList();
			if (weaponConfList == null)
			{
				goto IL_A7;
			}
			using (IEnumerator<Mapping> enumerator = weaponConfList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Mapping mapping = enumerator.Current;
					if (mapping.Value == data)
					{
						base.SetTextureTransitionByPath(mapping.DetectionDropDownIcon, uiTextureTransitionComponent, EUISelectableSelectionState.EUISelectableSelectionState_MAX);
						newText = MappingConfig.Instance.GetWeaponConfComment(mapping.Comment);
						break;
					}
				}
				goto IL_A7;
			}
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("UiItem_DevelopmentGuide_AllTypeIcon");
		base.SetTextureTransitionByPath(resourcePath, uiTextureTransitionComponent, EUISelectableSelectionState.EUISelectableSelectionState_MAX);
		newText = (ConfigMultiTextLang.GetLocalTextNew("Text_FilterTextAllWeaponFetter_Text", null) ?? "");
		IL_A7:
		base.GetText(0).SetText(newText, true);
	}

	// Token: 0x02006E05 RID: 28165
	private enum EComponent
	{
		// Token: 0x040240BA RID: 147642
		TxtOption,
		// Token: 0x040240BB RID: 147643
		WeaponTexture
	}
}
