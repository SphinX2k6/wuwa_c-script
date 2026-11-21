using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200101C RID: 4124
public class FloroRanchCommonTipsView : UiViewBase
{
	// Token: 0x0600A3F6 RID: 41974 RVA: 0x003011B8 File Offset: 0x002FF3B8
	[NullableContext(1)]
	public FloroRanchCommonTipsView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A3F7 RID: 41975 RVA: 0x003011C4 File Offset: 0x002FF3C4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnCloseButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600A3F8 RID: 41976 RVA: 0x0030126C File Offset: 0x002FF46C
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchCommonTipsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchCommonTipsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A3F9 RID: 41977 RVA: 0x003012B0 File Offset: 0x002FF4B0
	protected override void OnBeforeShow()
	{
		IFloroRanchCommonTipParam param = this.OpenParam as IFloroRanchCommonTipParam;
		this.CommonTipItem.RefreshInfoTipByParam(param);
	}

	// Token: 0x0600A3FA RID: 41978 RVA: 0x003012D5 File Offset: 0x002FF4D5
	private void OnCloseButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04006059 RID: 24665
	[Nullable(1)]
	private FloroRanchCommonTipItem CommonTipItem;

	// Token: 0x0200723E RID: 29246
	private class EComponentDefine
	{
		// Token: 0x040252C6 RID: 152262
		public const int CommonTipItem = 0;

		// Token: 0x040252C7 RID: 152263
		public const int CloseButton = 1;
	}
}
