using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001765 RID: 5989
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineAttributePanel : UiPanelBase
{
	// Token: 0x0600AD88 RID: 44424 RVA: 0x00270F60 File Offset: 0x0026F160
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

	// Token: 0x0600AD89 RID: 44425 RVA: 0x0027100C File Offset: 0x0026F20C
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineAttributePanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineAttributePanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD8A RID: 44426 RVA: 0x00271050 File Offset: 0x0026F250
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

	// Token: 0x0600AD8B RID: 44427 RVA: 0x002710AF File Offset: 0x0026F2AF
	public void RefreshItemSwitch(IRefineAttrItemData data)
	{
		this.ItemMainNew.RefreshUi(data);
	}

	// Token: 0x0600AD8C RID: 44428 RVA: 0x002710BD File Offset: 0x0026F2BD
	[NullableContext(1)]
	public void BindClickCallBack(Action callback)
	{
		this.OnClickCallBack = callback;
	}

	// Token: 0x0600AD8D RID: 44429 RVA: 0x002710C6 File Offset: 0x0026F2C6
	private void OnClickMainNew()
	{
		if (this.OnClickCallBack != null)
		{
			this.OnClickCallBack();
		}
	}

	// Token: 0x04004EE1 RID: 20193
	private PhantomTipsAttributeItem ItemMainNow;

	// Token: 0x04004EE2 RID: 20194
	private PhantomTipsAttributeItem ItemSubNow;

	// Token: 0x04004EE3 RID: 20195
	private PhantomTipsAttributeItem ItemSubNew;

	// Token: 0x04004EE4 RID: 20196
	private AttributeSelectItem ItemMainNew;

	// Token: 0x04004EE5 RID: 20197
	private Action OnClickCallBack;

	// Token: 0x02007D56 RID: 32086
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040290AE RID: 168110
		TextTips,
		// Token: 0x040290AF RID: 168111
		ItemMainNow,
		// Token: 0x040290B0 RID: 168112
		ItemMainNew,
		// Token: 0x040290B1 RID: 168113
		ItemSubNow,
		// Token: 0x040290B2 RID: 168114
		ItemSubNew
	}
}
