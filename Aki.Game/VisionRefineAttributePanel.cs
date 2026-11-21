using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C1E RID: 3102
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineAttributePanel : UiPanelBase
{
	// Token: 0x0600816F RID: 33135 RVA: 0x0027B420 File Offset: 0x00279620
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickMainNew))
		};
	}

	// Token: 0x06008170 RID: 33136 RVA: 0x0027B4CC File Offset: 0x002796CC
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineAttributePanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineAttributePanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008171 RID: 33137 RVA: 0x0027B510 File Offset: 0x00279710
	[NullableContext(1)]
	public void RefreshItemNow(AttrListScrollData[] dataList)
	{
		if (dataList.Length < 2)
		{
			Log.Instance.Error(ELogModule.Calabash, ELogAuthor.WDX, "声骸属性少于2", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		AttrListScrollData attributeData = dataList[0];
		AttrListScrollData attributeData2 = dataList[1];
		this.ItemMainNow.RefreshUi(attributeData);
		this.ItemSubNow.RefreshUi(attributeData2);
		this.ItemSubNew.RefreshUi(attributeData2);
	}

	// Token: 0x06008172 RID: 33138 RVA: 0x0027B56F File Offset: 0x0027976F
	public void RefreshItemSwitch(IRefineAttrItemData data)
	{
		this.ItemMainNew.RefreshUi(data);
	}

	// Token: 0x06008173 RID: 33139 RVA: 0x0027B57D File Offset: 0x0027977D
	[NullableContext(1)]
	public void BindClickCallBack(Action callback)
	{
		this.OnClickCallBack = callback;
	}

	// Token: 0x06008174 RID: 33140 RVA: 0x0027B586 File Offset: 0x00279786
	private void OnClickMainNew()
	{
		if (this.OnClickCallBack != null)
		{
			this.OnClickCallBack();
		}
	}

	// Token: 0x04004F8B RID: 20363
	private PhantomTipsAttributeItem ItemMainNow;

	// Token: 0x04004F8C RID: 20364
	private PhantomTipsAttributeItem ItemSubNow;

	// Token: 0x04004F8D RID: 20365
	private PhantomTipsAttributeItem ItemSubNew;

	// Token: 0x04004F8E RID: 20366
	private AttributeSelectItem ItemMainNew;

	// Token: 0x04004F8F RID: 20367
	private Action OnClickCallBack;

	// Token: 0x02006EDC RID: 28380
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040243D9 RID: 148441
		TextTips,
		// Token: 0x040243DA RID: 148442
		ItemMainNow,
		// Token: 0x040243DB RID: 148443
		ItemMainNew,
		// Token: 0x040243DC RID: 148444
		ItemSubNow,
		// Token: 0x040243DD RID: 148445
		ItemSubNew
	}
}
