using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002186 RID: 8582
public class TowerUnlockView : UiViewBase
{
	// Token: 0x060150C9 RID: 86217 RVA: 0x00622CC7 File Offset: 0x00620EC7
	[NullableContext(1)]
	public TowerUnlockView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060150CA RID: 86218 RVA: 0x00622CD0 File Offset: 0x00620ED0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060150CB RID: 86219 RVA: 0x00622D76 File Offset: 0x00620F76
	private void OnClickedCloseButton()
	{
		if (!this.CanClick)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x060150CC RID: 86220 RVA: 0x00622D88 File Offset: 0x00620F88
	protected override void OnStart()
	{
		int num = (int)this.OpenParam;
		if (num == 4)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PrefabTextItem_2260577568_Text", Array.Empty<object>());
			return;
		}
		string newTowerDifficultTitle = TowerClimbConfig.Instance.GetNewTowerDifficultTitle(num);
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(newTowerDifficultTitle, true);
	}

	// Token: 0x060150CD RID: 86221 RVA: 0x00622DE0 File Offset: 0x00620FE0
	protected override void OnAfterPlayStartSequence()
	{
		this.CanClick = true;
	}

	// Token: 0x0400B319 RID: 45849
	private bool CanClick;

	// Token: 0x02008419 RID: 33817
	private enum EChildType
	{
		// Token: 0x0402A9EC RID: 174572
		BtnMask,
		// Token: 0x0402A9ED RID: 174573
		TxtTitle
	}
}
