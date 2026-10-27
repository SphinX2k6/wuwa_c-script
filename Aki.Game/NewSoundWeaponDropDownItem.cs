using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x020016A6 RID: 5798
public class NewSoundWeaponDropDownItem : DropDownItemBase<int>
{
	// Token: 0x0600A575 RID: 42357 RVA: 0x0024FB0A File Offset: 0x0024DD0A
	[NullableContext(1)]
	public NewSoundWeaponDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x0600A576 RID: 42358 RVA: 0x0024FB14 File Offset: 0x0024DD14
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITextureTransitionComponent));
		this.ComponentRegisterInfos = list;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
	}

	// Token: 0x0600A577 RID: 42359 RVA: 0x0024FBA9 File Offset: 0x0024DDA9
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600A578 RID: 42360 RVA: 0x0024FBB4 File Offset: 0x0024DDB4
	protected override void OnShowDropDownItemBase(int data)
	{
		UUITextureTransitionComponent uiTextureTransitionComponent = base.GetUiTextureTransitionComponent(2);
		string newText = "";
		if (data > 0)
		{
			IReadOnlyList<Mapping> weaponConfList = MappingConfig.Instance.GetWeaponConfList();
			if (weaponConfList == null)
			{
				goto IL_B0;
			}
			using (IEnumerator<Mapping> enumerator = weaponConfList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Mapping mapping = enumerator.Current;
					if (mapping.Value == data)
					{
						base.SetTextureTransitionByPath(mapping.DetectionDropDownIcon, uiTextureTransitionComponent, EUISelectableSelectionState.EUISelectableSelectionState_MAX);
						newText = (MappingConfig.Instance.GetWeaponConfComment(mapping.Comment) ?? "");
						break;
					}
				}
				goto IL_B0;
			}
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("UiItem_DevelopmentGuide_AllTypeIcon");
		base.SetTextureTransitionByPath(resourcePath, uiTextureTransitionComponent, EUISelectableSelectionState.EUISelectableSelectionState_MAX);
		newText = (ConfigMultiTextLang.GetLocalTextNew("Text_FilterTextAllWeaponFetter_Text", null) ?? "");
		IL_B0:
		base.GetText(1).SetText(newText, true);
	}

	// Token: 0x02007C7D RID: 31869
	private enum EComponent
	{
		// Token: 0x04028D88 RID: 167304
		TogOption,
		// Token: 0x04028D89 RID: 167305
		TxtOption,
		// Token: 0x04028D8A RID: 167306
		WeaponTexture
	}
}
