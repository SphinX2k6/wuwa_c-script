using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000DA4 RID: 3492
[NullableContext(1)]
[Nullable(0)]
public class ItemTipsWithButtonComponent : UiPanelBase
{
	// Token: 0x06008ED3 RID: 36563 RVA: 0x002AF984 File Offset: 0x002ADB84
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickPreview));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008ED4 RID: 36564 RVA: 0x002AFAB0 File Offset: 0x002ADCB0
	protected override UniTask OnBeforeStartAsync()
	{
		ItemTipsWithButtonComponent.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemTipsWithButtonComponent.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008ED5 RID: 36565 RVA: 0x002AFAF3 File Offset: 0x002ADCF3
	protected override void OnStart()
	{
		this.ButtonLayout = new GenericLayout<LayoutButtonItem, ButtonItemData>(base.GetHorizontalLayout(1), this.InitGridItem, base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06008ED6 RID: 36566 RVA: 0x002AFB20 File Offset: 0x002ADD20
	protected override void OnBeforeDestroy()
	{
		this.ItemTipsComponentContentComponent.Destroy(null);
		this.ButtonLayout.ClearChildren();
	}

	// Token: 0x06008ED7 RID: 36567 RVA: 0x002AFB39 File Offset: 0x002ADD39
	public void RefreshTips(ItemTipsData tipsData)
	{
		this.ItemTipsComponentContentComponent.Refresh(tipsData);
	}

	// Token: 0x06008ED8 RID: 36568 RVA: 0x002AFB47 File Offset: 0x002ADD47
	public void SetTipsNumShow(bool isShow)
	{
		this.ItemTipsComponentContentComponent.SetTipsNumShow(isShow);
	}

	// Token: 0x06008ED9 RID: 36569 RVA: 0x002AFB58 File Offset: 0x002ADD58
	public void RefreshButton(List<IButtonInfo> buttonData)
	{
		this.ReloadFinishState = new CustomPromise();
		List<ButtonItemData> list = new List<ButtonItemData>();
		foreach (IButtonInfo buttonInfo in buttonData)
		{
			list.Add(new ButtonItemData
			{
				OnClickCallback = buttonInfo.Function,
				ButtonText = buttonInfo.Text,
				RedDotName = buttonInfo.RedDotName,
				Index = buttonInfo.Index
			});
		}
		this.ButtonLayout.RefreshByData(list, delegate
		{
			if (!this.ReloadFinishState.IsFulfilled)
			{
				CustomPromise reloadFinishState = this.ReloadFinishState;
				if (reloadFinishState == null)
				{
					return;
				}
				reloadFinishState.SetResult();
			}
		}, false);
	}

	// Token: 0x06008EDA RID: 36570 RVA: 0x002AFC08 File Offset: 0x002ADE08
	public void ClearButtonList()
	{
		this.ButtonLayout.RefreshByData(new List<ButtonItemData>(), null, false);
	}

	// Token: 0x06008EDB RID: 36571 RVA: 0x002AFC1C File Offset: 0x002ADE1C
	public UniTask SetButtonTextByIndex(int index, string text, [Nullable(new byte[]
	{
		2,
		1
	})] string[] textParams = null)
	{
		ItemTipsWithButtonComponent.<SetButtonTextByIndex>d__14 <SetButtonTextByIndex>d__;
		<SetButtonTextByIndex>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetButtonTextByIndex>d__.<>4__this = this;
		<SetButtonTextByIndex>d__.index = index;
		<SetButtonTextByIndex>d__.text = text;
		<SetButtonTextByIndex>d__.textParams = textParams;
		<SetButtonTextByIndex>d__.<>1__state = -1;
		<SetButtonTextByIndex>d__.<>t__builder.Start<ItemTipsWithButtonComponent.<SetButtonTextByIndex>d__14>(ref <SetButtonTextByIndex>d__);
		return <SetButtonTextByIndex>d__.<>t__builder.Task;
	}

	// Token: 0x06008EDC RID: 36572 RVA: 0x002AFC78 File Offset: 0x002ADE78
	public UniTask SetButtonEnableByIndex(int index, bool bEnable)
	{
		ItemTipsWithButtonComponent.<SetButtonEnableByIndex>d__15 <SetButtonEnableByIndex>d__;
		<SetButtonEnableByIndex>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetButtonEnableByIndex>d__.<>4__this = this;
		<SetButtonEnableByIndex>d__.index = index;
		<SetButtonEnableByIndex>d__.bEnable = bEnable;
		<SetButtonEnableByIndex>d__.<>1__state = -1;
		<SetButtonEnableByIndex>d__.<>t__builder.Start<ItemTipsWithButtonComponent.<SetButtonEnableByIndex>d__15>(ref <SetButtonEnableByIndex>d__);
		return <SetButtonEnableByIndex>d__.<>t__builder.Task;
	}

	// Token: 0x06008EDD RID: 36573 RVA: 0x002AFCCC File Offset: 0x002ADECC
	public void SetButtonPanelVisible(bool isVisible)
	{
		base.GetHorizontalLayout(1).RootUIComp.Get().SetUIActive(isVisible);
	}

	// Token: 0x06008EDE RID: 36574 RVA: 0x002AFCF4 File Offset: 0x002ADEF4
	public UniTask SetButtonRedDotVisible(int index, bool bVisible)
	{
		ItemTipsWithButtonComponent.<SetButtonRedDotVisible>d__17 <SetButtonRedDotVisible>d__;
		<SetButtonRedDotVisible>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetButtonRedDotVisible>d__.<>4__this = this;
		<SetButtonRedDotVisible>d__.index = index;
		<SetButtonRedDotVisible>d__.bVisible = bVisible;
		<SetButtonRedDotVisible>d__.<>1__state = -1;
		<SetButtonRedDotVisible>d__.<>t__builder.Start<ItemTipsWithButtonComponent.<SetButtonRedDotVisible>d__17>(ref <SetButtonRedDotVisible>d__);
		return <SetButtonRedDotVisible>d__.<>t__builder.Task;
	}

	// Token: 0x06008EDF RID: 36575 RVA: 0x002AFD47 File Offset: 0x002ADF47
	public void SetVisible(bool isShow)
	{
		this.SetActive(isShow);
	}

	// Token: 0x06008EE0 RID: 36576 RVA: 0x002AFD50 File Offset: 0x002ADF50
	public void SetTipsComponentLockButton(bool isShow)
	{
		this.ItemTipsComponentContentComponent.SetTipsComponentLockButton(isShow);
	}

	// Token: 0x06008EE1 RID: 36577 RVA: 0x002AFD5E File Offset: 0x002ADF5E
	[NullableContext(2)]
	public void SetLockStateData(IItemTipsLockStateData data = null)
	{
		this.LockState.UpdateData(data);
	}

	// Token: 0x06008EE2 RID: 36578 RVA: 0x002AFD6C File Offset: 0x002ADF6C
	public void SetLockStateVisible(bool isShow = false)
	{
		this.LockState.SetActive(isShow);
	}

	// Token: 0x06008EE3 RID: 36579 RVA: 0x002AFD7A File Offset: 0x002ADF7A
	public void SetPreviewVisible(bool isPreview = false)
	{
		base.GetItem(4).SetUIActive(isPreview);
	}

	// Token: 0x06008EE4 RID: 36580 RVA: 0x002AFD8C File Offset: 0x002ADF8C
	private void OnClickPreview()
	{
		ESkipName tipsPreviewType = this.ItemTipsComponentContentComponent.GetTipsPreviewType();
		int tipsItemConfigId = this.ItemTipsComponentContentComponent.GetTipsItemConfigId();
		SkipTaskManager.Run(tipsPreviewType, new object[]
		{
			tipsItemConfigId
		});
	}

	// Token: 0x04005597 RID: 21911
	[Nullable(2)]
	private ItemTipsComponentContentComponent ItemTipsComponentContentComponent;

	// Token: 0x04005598 RID: 21912
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<LayoutButtonItem, ButtonItemData> ButtonLayout;

	// Token: 0x04005599 RID: 21913
	[Nullable(2)]
	private CustomPromise ReloadFinishState;

	// Token: 0x0400559A RID: 21914
	[Nullable(2)]
	private ItemTipsLockState LockState;

	// Token: 0x0400559B RID: 21915
	private readonly Func<LayoutButtonItem> InitGridItem = () => new LayoutButtonItem();

	// Token: 0x02006FE1 RID: 28641
	[NullableContext(0)]
	private enum EItemTipsWithButtonNode
	{
		// Token: 0x040248B7 RID: 149687
		TipsItem,
		// Token: 0x040248B8 RID: 149688
		PanelBtn,
		// Token: 0x040248B9 RID: 149689
		Button,
		// Token: 0x040248BA RID: 149690
		LockState,
		// Token: 0x040248BB RID: 149691
		PanelPreview,
		// Token: 0x040248BC RID: 149692
		BtnPreview
	}
}
