using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020016A8 RID: 5800
public class WeaponTitleItem : TitleItemBase<int>
{
	// Token: 0x0600A57D RID: 42365 RVA: 0x0024FDFF File Offset: 0x0024DFFF
	[NullableContext(1)]
	public WeaponTitleItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600A57E RID: 42366 RVA: 0x0024FE08 File Offset: 0x0024E008
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

	// Token: 0x0600A57F RID: 42367 RVA: 0x0024FE74 File Offset: 0x0024E074
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

	// Token: 0x02007C80 RID: 31872
	private enum EComponent
	{
		// Token: 0x04028D91 RID: 167313
		TxtOption,
		// Token: 0x04028D92 RID: 167314
		WeaponTexture
	}
}
