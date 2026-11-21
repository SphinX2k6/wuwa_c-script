using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014F8 RID: 5368
[NullableContext(2)]
[Nullable(0)]
public class ItemConvertTipsView : UiViewBase
{
	// Token: 0x0600D66B RID: 54891 RVA: 0x003F96F2 File Offset: 0x003F78F2
	[NullableContext(1)]
	public ItemConvertTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D66C RID: 54892 RVA: 0x003F96FC File Offset: 0x003F78FC
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

	// Token: 0x0600D66D RID: 54893 RVA: 0x003F97C8 File Offset: 0x003F79C8
	private void OnCancelButtonClick(int _)
	{
		this.Param.OnCancelCallBack();
		base.CloseMe(null);
	}

	// Token: 0x0600D66E RID: 54894 RVA: 0x003F97E1 File Offset: 0x003F79E1
	private void OnConfirmButtonClick(int _)
	{
		this.Param.OnConfirmCallBack();
		base.CloseMe(null);
	}

	// Token: 0x0600D66F RID: 54895 RVA: 0x003F97FC File Offset: 0x003F79FC
	protected override UniTask OnBeforeStartAsync()
	{
		ItemConvertTipsView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemConvertTipsView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D670 RID: 54896 RVA: 0x003F983F File Offset: 0x003F7A3F
	protected override void OnBeforeShow()
	{
		this.Refresh(this.Param);
	}

	// Token: 0x0600D671 RID: 54897 RVA: 0x003F9850 File Offset: 0x003F7A50
	[NullableContext(1)]
	public void Refresh(ItemConvertTipsParam param)
	{
		this.BeforeItem.Refresh(param.BeforeItemData.Value);
		this.AfterItem.Refresh(param.AfterItemData.Value);
		base.GetText(0).SetText(param.ShowText, true);
	}

	// Token: 0x04007841 RID: 30785
	private ItemConvertTipsParam Param;

	// Token: 0x04007842 RID: 30786
	private CommonItemSmallItemGrid BeforeItem;

	// Token: 0x04007843 RID: 30787
	private CommonItemSmallItemGrid AfterItem;

	// Token: 0x04007844 RID: 30788
	private ButtonItem CancelButton;

	// Token: 0x04007845 RID: 30789
	private ButtonItem ConfirmButton;
}
