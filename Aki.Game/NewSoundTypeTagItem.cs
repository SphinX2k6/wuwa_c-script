using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B64 RID: 2916
public class NewSoundTypeTagItem : UiPanelBase
{
	// Token: 0x0600796F RID: 31087 RVA: 0x0025A70C File Offset: 0x0025890C
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

	// Token: 0x06007970 RID: 31088 RVA: 0x0025A778 File Offset: 0x00258978
	public void RefreshItem(bool isActivity)
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(isActivity ? "SP_TagFrameBgOrange" : "SP_TagFrameBgYellow");
		this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		base.GetText(1).SetColor(FColor.FromHex(isActivity ? "#312844" : "#232F2C"));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), isActivity ? "MaterialAcitivityTag" : "PrefabTextItem_4042540642_Text", Array.Empty<object>());
	}

	// Token: 0x02006E08 RID: 28168
	private enum ENodeDefine
	{
		// Token: 0x040240C7 RID: 147655
		BgSprite,
		// Token: 0x040240C8 RID: 147656
		Text
	}
}
