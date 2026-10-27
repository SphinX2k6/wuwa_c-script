using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001FE3 RID: 8163
public class PhantomSmartDiscardPopupActivatePanel : UiPanelBase
{
	// Token: 0x0600FFDB RID: 65499 RVA: 0x003E51E4 File Offset: 0x003E33E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600FFDC RID: 65500 RVA: 0x003E5270 File Offset: 0x003E3470
	protected override void OnStart()
	{
		string key = FunctionModel.Instance.IsOpen(10096) ? "PrefabTextItem_18455432_Text" : "PhantomManagementLocked_Tips";
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(key);
	}

	// Token: 0x020085F7 RID: 34295
	private enum EPanel
	{
		// Token: 0x0402B9A5 RID: 178597
		SpriteLock,
		// Token: 0x0402B9A6 RID: 178598
		TxtActivate,
		// Token: 0x0402B9A7 RID: 178599
		BtnFunctionA
	}
}
