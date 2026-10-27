using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002025 RID: 8229
[NullableContext(2)]
[Nullable(0)]
public class ItemConvertTipsView : UiViewBase
{
	// Token: 0x06010203 RID: 66051 RVA: 0x003ED0FA File Offset: 0x003EB2FA
	[NullableContext(1)]
	public ItemConvertTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010204 RID: 66052 RVA: 0x003ED104 File Offset: 0x003EB304
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

	// Token: 0x06010205 RID: 66053 RVA: 0x003ED1D0 File Offset: 0x003EB3D0
	private void OnCancelButtonClick(int _)
	{
		this.Param.OnCancelCallBack();
		base.CloseMe(null);
	}

	// Token: 0x06010206 RID: 66054 RVA: 0x003ED1E9 File Offset: 0x003EB3E9
	private void OnConfirmButtonClick(int _)
	{
		this.Param.OnConfirmCallBack();
		base.CloseMe(null);
	}

	// Token: 0x06010207 RID: 66055 RVA: 0x003ED204 File Offset: 0x003EB404
	protected override UniTask OnBeforeStartAsync()
	{
		ItemConvertTipsView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemConvertTipsView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010208 RID: 66056 RVA: 0x003ED247 File Offset: 0x003EB447
	protected override void OnBeforeShow()
	{
		this.Refresh(this.Param);
	}

	// Token: 0x06010209 RID: 66057 RVA: 0x003ED258 File Offset: 0x003EB458
	[NullableContext(1)]
	public void Refresh(ItemConvertTipsParam param)
	{
		this.BeforeItem.Refresh(param.BeforeItemData.Value);
		this.AfterItem.Refresh(param.AfterItemData.Value);
		base.GetText(0).SetText(param.ShowText, true);
	}

	// Token: 0x04007758 RID: 30552
	private ItemConvertTipsParam Param;

	// Token: 0x04007759 RID: 30553
	private CommonItemSmallItemGrid BeforeItem;

	// Token: 0x0400775A RID: 30554
	private CommonItemSmallItemGrid AfterItem;

	// Token: 0x0400775B RID: 30555
	private ButtonItem CancelButton;

	// Token: 0x0400775C RID: 30556
	private ButtonItem ConfirmButton;
}
