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

// Token: 0x020018EB RID: 6379
[NullableContext(1)]
[Nullable(0)]
public class ItemTipsWithButtonComponent : UiPanelBase
{
	// Token: 0x0600BAEA RID: 47850 RVA: 0x002A5224 File Offset: 0x002A3424
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

	// Token: 0x0600BAEB RID: 47851 RVA: 0x002A5350 File Offset: 0x002A3550
	protected override UniTask OnBeforeStartAsync()
	{
		ItemTipsWithButtonComponent.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemTipsWithButtonComponent.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BAEC RID: 47852 RVA: 0x002A5393 File Offset: 0x002A3593
	protected override void OnStart()
	{
		this.ButtonLayout = new GenericLayout<LayoutButtonItem, ButtonItemData>(base.GetHorizontalLayout(1), this.InitGridItem, base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x0600BAED RID: 47853 RVA: 0x002A53C0 File Offset: 0x002A35C0
	protected override void OnBeforeDestroy()
	{
		this.ItemTipsComponentContentComponent.Destroy(null);
		this.ButtonLayout.ClearChildren();
	}

	// Token: 0x0600BAEE RID: 47854 RVA: 0x002A53D9 File Offset: 0x002A35D9
	public void RefreshTips(ItemTipsData tipsData)
	{
		this.ItemTipsComponentContentComponent.Refresh(tipsData);
	}

	// Token: 0x0600BAEF RID: 47855 RVA: 0x002A53E8 File Offset: 0x002A35E8
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

	// Token: 0x0600BAF0 RID: 47856 RVA: 0x002A5498 File Offset: 0x002A3698
	public void ClearButtonList()
	{
		this.ButtonLayout.RefreshByData(new List<ButtonItemData>(), null, false);
	}

	// Token: 0x0600BAF1 RID: 47857 RVA: 0x002A54AC File Offset: 0x002A36AC
	public UniTask SetButtonTextByIndex(int index, string text, [Nullable(new byte[]
	{
		2,
		1
	})] string[] textParams = null)
	{
		ItemTipsWithButtonComponent.<SetButtonTextByIndex>d__13 <SetButtonTextByIndex>d__;
		<SetButtonTextByIndex>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetButtonTextByIndex>d__.<>4__this = this;
		<SetButtonTextByIndex>d__.index = index;
		<SetButtonTextByIndex>d__.text = text;
		<SetButtonTextByIndex>d__.textParams = textParams;
		<SetButtonTextByIndex>d__.<>1__state = -1;
		<SetButtonTextByIndex>d__.<>t__builder.Start<ItemTipsWithButtonComponent.<SetButtonTextByIndex>d__13>(ref <SetButtonTextByIndex>d__);
		return <SetButtonTextByIndex>d__.<>t__builder.Task;
	}

	// Token: 0x0600BAF2 RID: 47858 RVA: 0x002A5508 File Offset: 0x002A3708
	public UniTask SetButtonEnableByIndex(int index, bool bEnable)
	{
		ItemTipsWithButtonComponent.<SetButtonEnableByIndex>d__14 <SetButtonEnableByIndex>d__;
		<SetButtonEnableByIndex>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetButtonEnableByIndex>d__.<>4__this = this;
		<SetButtonEnableByIndex>d__.index = index;
		<SetButtonEnableByIndex>d__.bEnable = bEnable;
		<SetButtonEnableByIndex>d__.<>1__state = -1;
		<SetButtonEnableByIndex>d__.<>t__builder.Start<ItemTipsWithButtonComponent.<SetButtonEnableByIndex>d__14>(ref <SetButtonEnableByIndex>d__);
		return <SetButtonEnableByIndex>d__.<>t__builder.Task;
	}

	// Token: 0x0600BAF3 RID: 47859 RVA: 0x002A555C File Offset: 0x002A375C
	public void SetButtonPanelVisible(bool isVisible)
	{
		base.GetHorizontalLayout(1).RootUIComp.Get().SetUIActive(isVisible);
	}

	// Token: 0x0600BAF4 RID: 47860 RVA: 0x002A5584 File Offset: 0x002A3784
	public UniTask SetButtonRedDotVisible(int index, bool bVisible)
	{
		ItemTipsWithButtonComponent.<SetButtonRedDotVisible>d__16 <SetButtonRedDotVisible>d__;
		<SetButtonRedDotVisible>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetButtonRedDotVisible>d__.<>4__this = this;
		<SetButtonRedDotVisible>d__.index = index;
		<SetButtonRedDotVisible>d__.bVisible = bVisible;
		<SetButtonRedDotVisible>d__.<>1__state = -1;
		<SetButtonRedDotVisible>d__.<>t__builder.Start<ItemTipsWithButtonComponent.<SetButtonRedDotVisible>d__16>(ref <SetButtonRedDotVisible>d__);
		return <SetButtonRedDotVisible>d__.<>t__builder.Task;
	}

	// Token: 0x0600BAF5 RID: 47861 RVA: 0x002A55D7 File Offset: 0x002A37D7
	public void SetVisible(bool isShow)
	{
		this.SetActive(isShow);
	}

	// Token: 0x0600BAF6 RID: 47862 RVA: 0x002A55E0 File Offset: 0x002A37E0
	public void SetTipsComponentLockButton(bool isShow)
	{
		this.ItemTipsComponentContentComponent.SetTipsComponentLockButton(isShow);
	}

	// Token: 0x0600BAF7 RID: 47863 RVA: 0x002A55EE File Offset: 0x002A37EE
	[NullableContext(2)]
	public void SetLockStateData(IItemTipsLockStateData data = null)
	{
		this.LockState.UpdateData(data);
	}

	// Token: 0x0600BAF8 RID: 47864 RVA: 0x002A55FC File Offset: 0x002A37FC
	public void SetLockStateVisible(bool isShow = false)
	{
		this.LockState.SetActive(isShow);
	}

	// Token: 0x0600BAF9 RID: 47865 RVA: 0x002A560A File Offset: 0x002A380A
	public void SetPreviewVisible(bool isPreview = false)
	{
		base.GetItem(4).SetUIActive(isPreview);
	}

	// Token: 0x0600BAFA RID: 47866 RVA: 0x002A561C File Offset: 0x002A381C
	private void OnClickPreview()
	{
		ESkipName tipsPreviewType = this.ItemTipsComponentContentComponent.GetTipsPreviewType();
		int tipsItemConfigId = this.ItemTipsComponentContentComponent.GetTipsItemConfigId();
		SkipTaskManager.Run(tipsPreviewType, new object[]
		{
			tipsItemConfigId
		});
	}

	// Token: 0x040054EC RID: 21740
	[Nullable(2)]
	private ItemTipsComponentContentComponent ItemTipsComponentContentComponent;

	// Token: 0x040054ED RID: 21741
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<LayoutButtonItem, ButtonItemData> ButtonLayout;

	// Token: 0x040054EE RID: 21742
	[Nullable(2)]
	private CustomPromise ReloadFinishState;

	// Token: 0x040054EF RID: 21743
	[Nullable(2)]
	private ItemTipsLockState LockState;

	// Token: 0x040054F0 RID: 21744
	private readonly Func<LayoutButtonItem> InitGridItem = () => new LayoutButtonItem();

	// Token: 0x02007E5A RID: 32346
	[NullableContext(0)]
	private enum EItemTipsWithButtonNode
	{
		// Token: 0x0402958A RID: 169354
		TipsItem,
		// Token: 0x0402958B RID: 169355
		PanelBtn,
		// Token: 0x0402958C RID: 169356
		Button,
		// Token: 0x0402958D RID: 169357
		LockState,
		// Token: 0x0402958E RID: 169358
		PanelPreview,
		// Token: 0x0402958F RID: 169359
		BtnPreview
	}
}
