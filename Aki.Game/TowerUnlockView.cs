using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002C0B RID: 11275
public class TowerUnlockView : UiViewBase
{
	// Token: 0x06017698 RID: 95896 RVA: 0x005F61A3 File Offset: 0x005F43A3
	[NullableContext(1)]
	public TowerUnlockView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06017699 RID: 95897 RVA: 0x005F61AC File Offset: 0x005F43AC
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

	// Token: 0x0601769A RID: 95898 RVA: 0x005F6252 File Offset: 0x005F4452
	private void OnClickedCloseButton()
	{
		if (!this.CanClick)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0601769B RID: 95899 RVA: 0x005F6264 File Offset: 0x005F4464
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

	// Token: 0x0601769C RID: 95900 RVA: 0x005F62BC File Offset: 0x005F44BC
	protected override void OnAfterPlayStartSequence()
	{
		this.CanClick = true;
	}

	// Token: 0x0400AF14 RID: 44820
	private bool CanClick;

	// Token: 0x020091D6 RID: 37334
	private enum EChildType
	{
		// Token: 0x0402F2EB RID: 193259
		BtnMask,
		// Token: 0x0402F2EC RID: 193260
		TxtTitle
	}
}
