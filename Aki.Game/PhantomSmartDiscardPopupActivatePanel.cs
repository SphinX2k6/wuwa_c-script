using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014B6 RID: 5302
public class PhantomSmartDiscardPopupActivatePanel : UiPanelBase
{
	// Token: 0x0600D443 RID: 54339 RVA: 0x003F17E4 File Offset: 0x003EF9E4
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

	// Token: 0x0600D444 RID: 54340 RVA: 0x003F1870 File Offset: 0x003EFA70
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

	// Token: 0x0200777E RID: 30590
	private enum EPanel
	{
		// Token: 0x04026CB4 RID: 158900
		SpriteLock,
		// Token: 0x04026CB5 RID: 158901
		TxtActivate,
		// Token: 0x04026CB6 RID: 158902
		BtnFunctionA
	}
}
