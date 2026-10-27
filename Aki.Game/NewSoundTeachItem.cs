using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.AdventureGuide.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016A9 RID: 5801
public class NewSoundTeachItem : UiPanelBase, INewSoundItem
{
	// Token: 0x0600A581 RID: 42369 RVA: 0x0024FF50 File Offset: 0x0024E150
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A582 RID: 42370 RVA: 0x0024FFBC File Offset: 0x0024E1BC
	[NullableContext(1)]
	public void Update(NewSoundDetectItemData sourceData)
	{
		SoundAreaDetectionRecord detectRecordData = sourceData.DetectRecordData;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, detectRecordData.Name, Array.Empty<object>());
		UUITexture texture = base.GetTexture(1);
		base.SetTextureShowUntilLoaded(detectRecordData.BigIcon, texture, null);
	}

	// Token: 0x02007C81 RID: 31873
	private enum EChildType
	{
		// Token: 0x04028D94 RID: 167316
		NameText,
		// Token: 0x04028D95 RID: 167317
		IconTexture
	}
}
