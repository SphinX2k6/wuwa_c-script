using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000B5E RID: 2910
public class NewSoundWeaponDropDownItem : DropDownItemBase<int>
{
	// Token: 0x06007955 RID: 31061 RVA: 0x00259F1E File Offset: 0x0025811E
	[NullableContext(1)]
	public NewSoundWeaponDropDownItem(UUIItem uiItem) : base(uiItem)
	{
	}

	// Token: 0x06007956 RID: 31062 RVA: 0x00259F28 File Offset: 0x00258128
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

	// Token: 0x06007957 RID: 31063 RVA: 0x00259FBD File Offset: 0x002581BD
	[NullableContext(2)]
	protected override UUIExtendToggle GetDropDownToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06007958 RID: 31064 RVA: 0x00259FC8 File Offset: 0x002581C8
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

	// Token: 0x02006E02 RID: 28162
	private enum EComponent
	{
		// Token: 0x040240B1 RID: 147633
		TogOption,
		// Token: 0x040240B2 RID: 147634
		TxtOption,
		// Token: 0x040240B3 RID: 147635
		WeaponTexture
	}
}
