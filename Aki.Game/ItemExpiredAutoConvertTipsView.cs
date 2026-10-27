using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FCE RID: 8142
[NullableContext(2)]
[Nullable(0)]
public class ItemExpiredAutoConvertTipsView : UiViewBase
{
	// Token: 0x0600FF31 RID: 65329 RVA: 0x003E22AC File Offset: 0x003E04AC
	[NullableContext(1)]
	public ItemExpiredAutoConvertTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FF32 RID: 65330 RVA: 0x003E22B8 File Offset: 0x003E04B8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600FF33 RID: 65331 RVA: 0x003E2384 File Offset: 0x003E0584
	protected override UniTask OnBeforeStartAsync()
	{
		ItemExpiredAutoConvertTipsView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemExpiredAutoConvertTipsView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FF34 RID: 65332 RVA: 0x003E23C8 File Offset: 0x003E05C8
	protected override void OnBeforeShow()
	{
		this.CancelButton.SetActive(this.Data.OnCancelCallBack != null);
		this.BeforeConvertShowItem.Refresh(this.Data.BeforeTitleText, this.Data.BeforeItemList);
		this.AfterConvertShowItem.Refresh(this.Data.AfterTitleText, this.Data.AfterItemList);
		base.GetText(0).ShowTextNew(this.Data.TitleText);
	}

	// Token: 0x04007613 RID: 30227
	private ItemExpiredAutoConvertTipsViewDefine Data;

	// Token: 0x04007614 RID: 30228
	private ButtonItem CancelButton;

	// Token: 0x04007615 RID: 30229
	private ButtonItem ConfirmButton;

	// Token: 0x04007616 RID: 30230
	private ConvertShowItem BeforeConvertShowItem;

	// Token: 0x04007617 RID: 30231
	private ConvertShowItem AfterConvertShowItem;
}
