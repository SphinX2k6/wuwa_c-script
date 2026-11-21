using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.AdventureGuide.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B61 RID: 2913
public class NewSoundTeachItem : UiPanelBase, INewSoundItem
{
	// Token: 0x06007961 RID: 31073 RVA: 0x0025A364 File Offset: 0x00258564
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

	// Token: 0x06007962 RID: 31074 RVA: 0x0025A3D0 File Offset: 0x002585D0
	[NullableContext(1)]
	public void Update(NewSoundDetectItemData sourceData)
	{
		SoundAreaDetectionRecord detectRecordData = sourceData.DetectRecordData;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, detectRecordData.Name, Array.Empty<object>());
		UUITexture texture = base.GetTexture(1);
		base.SetTextureShowUntilLoaded(detectRecordData.BigIcon, texture, null);
	}

	// Token: 0x02006E06 RID: 28166
	private enum EChildType
	{
		// Token: 0x040240BD RID: 147645
		NameText,
		// Token: 0x040240BE RID: 147646
		IconTexture
	}
}
