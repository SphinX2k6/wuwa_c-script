using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016AC RID: 5804
public class NewSoundTypeTagItem : UiPanelBase
{
	// Token: 0x0600A58F RID: 42383 RVA: 0x002502F8 File Offset: 0x0024E4F8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A590 RID: 42384 RVA: 0x00250364 File Offset: 0x0024E564
	public void RefreshItem(bool isActivity)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(isActivity ? "SP_TagFrameBgOrange" : "SP_TagFrameBgYellow");
		this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		base.GetText(1).SetColor(FColor.FromHex(isActivity ? "#312844" : "#232F2C"));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), isActivity ? "MaterialAcitivityTag" : "PrefabTextItem_4042540642_Text", Array.Empty<object>());
	}

	// Token: 0x02007C83 RID: 31875
	private enum ENodeDefine
	{
		// Token: 0x04028D9E RID: 167326
		BgSprite,
		// Token: 0x04028D9F RID: 167327
		Text
	}
}
