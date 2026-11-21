using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006AF RID: 1711
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingButton : UiPanelBase
{
	// Token: 0x06004EAC RID: 20140 RVA: 0x001A7C7C File Offset: 0x001A5E7C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004EAD RID: 20141 RVA: 0x001A7D64 File Offset: 0x001A5F64
	protected override void OnBeforeShow()
	{
		base.GetText(0).SetText("", true);
		base.GetText(2).SetText("", true);
	}

	// Token: 0x06004EAE RID: 20142 RVA: 0x001A7D8C File Offset: 0x001A5F8C
	public UniTask InitializeAsync(AActor rootActor, Action onClickCall)
	{
		ActivityCorniceMeetingButton.<InitializeAsync>d__4 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.rootActor = rootActor;
		<InitializeAsync>d__.onClickCall = onClickCall;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<ActivityCorniceMeetingButton.<InitializeAsync>d__4>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004EAF RID: 20143 RVA: 0x001A7DDF File Offset: 0x001A5FDF
	private void OnClickedButton()
	{
		Action onClickEvent = this.OnClickEvent;
		if (onClickEvent == null)
		{
			return;
		}
		onClickEvent();
	}

	// Token: 0x06004EB0 RID: 20144 RVA: 0x001A7DF1 File Offset: 0x001A5FF1
	public void SetFloatText(string textId, params string[] args)
	{
		base.GetText(2).SetUIActive(true);
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
	}

	// Token: 0x06004EB1 RID: 20145 RVA: 0x001A7E13 File Offset: 0x001A6013
	public void SetBtnText(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), textId, args);
	}

	// Token: 0x040038F5 RID: 14581
	[Nullable(2)]
	private Action OnClickEvent;

	// Token: 0x0200696D RID: 26989
	[NullableContext(0)]
	private class ESimpleButtonChildType
	{
		// Token: 0x04022B83 RID: 142211
		public const int ButtonText = 0;

		// Token: 0x04022B84 RID: 142212
		public const int DescriptionItem = 1;

		// Token: 0x04022B85 RID: 142213
		public const int DescriptionText = 2;

		// Token: 0x04022B86 RID: 142214
		public const int Button = 3;
	}
}
