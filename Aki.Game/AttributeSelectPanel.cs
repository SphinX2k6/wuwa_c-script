using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C1B RID: 3099
[NullableContext(1)]
[Nullable(0)]
public class AttributeSelectPanel : UiPanelBase
{
	// Token: 0x06008157 RID: 33111 RVA: 0x0027AF74 File Offset: 0x00279174
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06008158 RID: 33112 RVA: 0x0027AFD0 File Offset: 0x002791D0
	protected override void OnStart()
	{
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), "VisionRefineAttributeSelect", Array.Empty<object>());
		this.Layout = new GenericLayout<AttributeSelectGrid, IRefineAttrItemData>(base.GetGridLayout(0), new Func<AttributeSelectGrid>(this.InitAttributeItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06008159 RID: 33113 RVA: 0x0027B029 File Offset: 0x00279229
	private AttributeSelectGrid InitAttributeItem()
	{
		return new AttributeSelectGrid
		{
			OnClickToggleCallBack = new Action<IRefineAttrItemData, int>(this.OnClickAttributeItem)
		};
	}

	// Token: 0x0600815A RID: 33114 RVA: 0x0027B042 File Offset: 0x00279242
	public void RefreshByData(IRefineAttrItemData[] dataList, int? chosenIndex = null)
	{
		this.RefreshByDataAsync(dataList, chosenIndex).Forget();
	}

	// Token: 0x0600815B RID: 33115 RVA: 0x0027B054 File Offset: 0x00279254
	private UniTask RefreshByDataAsync(IRefineAttrItemData[] dataList, int? chosenIndex = null)
	{
		AttributeSelectPanel.<RefreshByDataAsync>d__7 <RefreshByDataAsync>d__;
		<RefreshByDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshByDataAsync>d__.<>4__this = this;
		<RefreshByDataAsync>d__.dataList = dataList;
		<RefreshByDataAsync>d__.chosenIndex = chosenIndex;
		<RefreshByDataAsync>d__.<>1__state = -1;
		<RefreshByDataAsync>d__.<>t__builder.Start<AttributeSelectPanel.<RefreshByDataAsync>d__7>(ref <RefreshByDataAsync>d__);
		return <RefreshByDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600815C RID: 33116 RVA: 0x0027B0A7 File Offset: 0x002792A7
	private void OnClickAttributeItem(IRefineAttrItemData data, int index)
	{
		if (this.CallBackClick != null)
		{
			this.CallBackClick(data);
		}
		this.Layout.DeselectCurrentGridProxy();
		this.Layout.SelectGridProxy(index, false);
	}

	// Token: 0x04004F7C RID: 20348
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AttributeSelectGrid, IRefineAttrItemData> Layout;

	// Token: 0x04004F7D RID: 20349
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IRefineAttrItemData> CallBackClick;

	// Token: 0x02006ED8 RID: 28376
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040243C4 RID: 148420
		Layout,
		// Token: 0x040243C5 RID: 148421
		LayoutItem,
		// Token: 0x040243C6 RID: 148422
		TextTitle
	}
}
