using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017AB RID: 6059
[NullableContext(1)]
[Nullable(0)]
public class QuickChatText : UiPanelBase
{
	// Token: 0x0600B0D3 RID: 45267 RVA: 0x00280876 File Offset: 0x0027EA76
	public QuickChatText(AActor rootActor)
	{
		base.CreateThenShowByActor(rootActor, null);
	}

	// Token: 0x0600B0D4 RID: 45268 RVA: 0x00280894 File Offset: 0x0027EA94
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

	// Token: 0x0600B0D5 RID: 45269 RVA: 0x0028093A File Offset: 0x0027EB3A
	protected override void OnBeforeDestroy()
	{
		this.OnClicked = null;
	}

	// Token: 0x0600B0D6 RID: 45270 RVA: 0x00280943 File Offset: 0x0027EB43
	private void OnClickedQuickChatButton()
	{
		Action<string> onClicked = this.OnClicked;
		if (onClicked == null)
		{
			return;
		}
		onClicked(this.QuickChatString);
	}

	// Token: 0x0600B0D7 RID: 45271 RVA: 0x0028095B File Offset: 0x0027EB5B
	public void Refresh(string quickChatString)
	{
		base.GetText(0).SetText(quickChatString, true);
		this.QuickChatString = quickChatString;
	}

	// Token: 0x0600B0D8 RID: 45272 RVA: 0x00280972 File Offset: 0x0027EB72
	public void BindOnClicked(Action<string> onClicked)
	{
		this.OnClicked = onClicked;
	}

	// Token: 0x04005038 RID: 20536
	private string QuickChatString = "";

	// Token: 0x04005039 RID: 20537
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<string> OnClicked;

	// Token: 0x02007DC3 RID: 32195
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040292C7 RID: 168647
		public const int QuickChatText = 0;

		// Token: 0x040292C8 RID: 168648
		public const int QuickChatButton = 1;
	}
}
