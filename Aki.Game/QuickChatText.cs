using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C64 RID: 3172
[NullableContext(1)]
[Nullable(0)]
public class QuickChatText : UiPanelBase
{
	// Token: 0x060084BB RID: 33979 RVA: 0x0028AE0E File Offset: 0x0028900E
	public QuickChatText(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x060084BC RID: 33980 RVA: 0x0028AE2C File Offset: 0x0028902C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickedQuickChatButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060084BD RID: 33981 RVA: 0x0028AED2 File Offset: 0x002890D2
	protected override void OnBeforeDestroy()
	{
		this.OnClicked = null;
	}

	// Token: 0x060084BE RID: 33982 RVA: 0x0028AEDB File Offset: 0x002890DB
	private void OnClickedQuickChatButton()
	{
		Action<string> onClicked = this.OnClicked;
		if (onClicked == null)
		{
			return;
		}
		onClicked(this.QuickChatString);
	}

	// Token: 0x060084BF RID: 33983 RVA: 0x0028AEF3 File Offset: 0x002890F3
	public void Refresh(string quickChatString)
	{
		base.GetText(0).SetText(quickChatString, true);
		this.QuickChatString = quickChatString;
	}

	// Token: 0x060084C0 RID: 33984 RVA: 0x0028AF0A File Offset: 0x0028910A
	public void BindOnClicked(Action<string> onClicked)
	{
		this.OnClicked = onClicked;
	}

	// Token: 0x040050E2 RID: 20706
	private string QuickChatString = "";

	// Token: 0x040050E3 RID: 20707
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<string> OnClicked;

	// Token: 0x02006F49 RID: 28489
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040245F2 RID: 148978
		public const int QuickChatText = 0;

		// Token: 0x040245F3 RID: 148979
		public const int QuickChatButton = 1;
	}
}
