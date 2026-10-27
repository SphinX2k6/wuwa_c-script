using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001762 RID: 5986
[NullableContext(1)]
[Nullable(0)]
public class AttributeSelectPanel : UiPanelBase
{
	// Token: 0x0600AD70 RID: 44400 RVA: 0x00270AB4 File Offset: 0x0026ECB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600AD71 RID: 44401 RVA: 0x00270B10 File Offset: 0x0026ED10
	protected override void OnStart()
	{
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), "VisionRefineAttributeSelect", Array.Empty<object>());
		this.Layout = new GenericLayout<AttributeSelectGrid, IRefineAttrItemData>(base.GetGridLayout(0), new Func<AttributeSelectGrid>(this.InitAttributeItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600AD72 RID: 44402 RVA: 0x00270B69 File Offset: 0x0026ED69
	private AttributeSelectGrid InitAttributeItem()
	{
		return new AttributeSelectGrid
		{
			OnClickToggleCallBack = new Action<IRefineAttrItemData, int>(this.OnClickAttributeItem)
		};
	}

	// Token: 0x0600AD73 RID: 44403 RVA: 0x00270B82 File Offset: 0x0026ED82
	public void RefreshByData(IRefineAttrItemData[] dataList, int? chosenIndex = null)
	{
		this.RefreshByDataAsync(dataList, chosenIndex).Forget();
	}

	// Token: 0x0600AD74 RID: 44404 RVA: 0x00270B94 File Offset: 0x0026ED94
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

	// Token: 0x0600AD75 RID: 44405 RVA: 0x00270BE7 File Offset: 0x0026EDE7
	private void OnClickAttributeItem(IRefineAttrItemData data, int index)
	{
		if (this.CallBackClick != null)
		{
			this.CallBackClick(data);
		}
		this.Layout.DeselectCurrentGridProxy();
		this.Layout.SelectGridProxy(index, false);
	}

	// Token: 0x04004ED2 RID: 20178
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<AttributeSelectGrid, IRefineAttrItemData> Layout;

	// Token: 0x04004ED3 RID: 20179
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<IRefineAttrItemData> CallBackClick;

	// Token: 0x02007D52 RID: 32082
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029099 RID: 168089
		Layout,
		// Token: 0x0402909A RID: 168090
		LayoutItem,
		// Token: 0x0402909B RID: 168091
		TextTitle
	}
}
