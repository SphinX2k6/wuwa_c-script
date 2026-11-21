using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014A1 RID: 5281
[NullableContext(2)]
[Nullable(0)]
public class ItemExpiredAutoConvertTipsView : UiViewBase
{
	// Token: 0x0600D399 RID: 54169 RVA: 0x003EE888 File Offset: 0x003ECA88
	[NullableContext(1)]
	public ItemExpiredAutoConvertTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D39A RID: 54170 RVA: 0x003EE894 File Offset: 0x003ECA94
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

	// Token: 0x0600D39B RID: 54171 RVA: 0x003EE960 File Offset: 0x003ECB60
	protected override UniTask OnBeforeStartAsync()
	{
		ItemExpiredAutoConvertTipsView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemExpiredAutoConvertTipsView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D39C RID: 54172 RVA: 0x003EE9A4 File Offset: 0x003ECBA4
	protected override void OnBeforeShow()
	{
		this.CancelButton.SetActive(this.Data.OnCancelCallBack != null);
		this.BeforeConvertShowItem.Refresh(this.Data.BeforeTitleText, this.Data.BeforeItemList);
		this.AfterConvertShowItem.Refresh(this.Data.AfterTitleText, this.Data.AfterItemList);
		base.GetText(0).ShowTextNew(this.Data.TitleText);
	}

	// Token: 0x040076FC RID: 30460
	private ItemExpiredAutoConvertTipsViewDefine Data;

	// Token: 0x040076FD RID: 30461
	private ButtonItem CancelButton;

	// Token: 0x040076FE RID: 30462
	private ButtonItem ConfirmButton;

	// Token: 0x040076FF RID: 30463
	private ConvertShowItem BeforeConvertShowItem;

	// Token: 0x04007700 RID: 30464
	private ConvertShowItem AfterConvertShowItem;
}
