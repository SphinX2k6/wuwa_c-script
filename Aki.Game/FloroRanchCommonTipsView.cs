using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B5D RID: 7005
public class FloroRanchCommonTipsView : UiViewBase
{
	// Token: 0x0600CFE5 RID: 53221 RVA: 0x002F60E0 File Offset: 0x002F42E0
	[NullableContext(1)]
	public FloroRanchCommonTipsView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600CFE6 RID: 53222 RVA: 0x002F60EC File Offset: 0x002F42EC
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

	// Token: 0x0600CFE7 RID: 53223 RVA: 0x002F6194 File Offset: 0x002F4394
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchCommonTipsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchCommonTipsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CFE8 RID: 53224 RVA: 0x002F61D8 File Offset: 0x002F43D8
	protected override void OnBeforeShow()
	{
		IFloroRanchCommonTipParam param = this.OpenParam as IFloroRanchCommonTipParam;
		this.CommonTipItem.RefreshInfoTipByParam(param);
	}

	// Token: 0x0600CFE9 RID: 53225 RVA: 0x002F61FD File Offset: 0x002F43FD
	private void OnCloseButtonClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04005F8A RID: 24458
	[Nullable(1)]
	private FloroRanchCommonTipItem CommonTipItem;

	// Token: 0x020080B0 RID: 32944
	private class EComponentDefine
	{
		// Token: 0x04029F92 RID: 171922
		public const int CommonTipItem = 0;

		// Token: 0x04029F93 RID: 171923
		public const int CloseButton = 1;
	}
}
