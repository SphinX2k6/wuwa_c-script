using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001771 RID: 6001
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineResultView : UiViewBase
{
	// Token: 0x0600AE03 RID: 44547 RVA: 0x0027357F File Offset: 0x0027177F
	public VisionRefineResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AE04 RID: 44548 RVA: 0x00273594 File Offset: 0x00271794
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnGoToPhantomLevelUp)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickMask)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickMask))
		};
	}

	// Token: 0x0600AE05 RID: 44549 RVA: 0x0027370C File Offset: 0x0027190C
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineResultView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineResultView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE06 RID: 44550 RVA: 0x00273750 File Offset: 0x00271950
	protected override void OnAfterShow()
	{
		List<int> list = new List<int>();
		foreach (PhantomItemData phantomItemData in this.ItemDataList)
		{
			int uniqueId = phantomItemData.GetUniqueId();
			AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(uniqueId);
			if (attributeItemData == null)
			{
				Log.Instance.Error(ELogModule.Calabash, ELogAuthor.WDX, "Proto_PhantomPolishResponse.Proto_UpdateInfo为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else if (attributeItemData.CanLock() && !attributeItemData.GetIsLock())
			{
				list.Add(uniqueId);
			}
		}
		if (list.Count > 0)
		{
			this.TryLockRefineVisions(list).Forget();
		}
	}

	// Token: 0x0600AE07 RID: 44551 RVA: 0x00273804 File Offset: 0x00271A04
	private UniTask TryLockRefineVisions(List<int> uidList)
	{
		VisionRefineResultView.<TryLockRefineVisions>d__8 <TryLockRefineVisions>d__;
		<TryLockRefineVisions>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryLockRefineVisions>d__.<>4__this = this;
		<TryLockRefineVisions>d__.uidList = uidList;
		<TryLockRefineVisions>d__.<>1__state = -1;
		<TryLockRefineVisions>d__.<>t__builder.Start<VisionRefineResultView.<TryLockRefineVisions>d__8>(ref <TryLockRefineVisions>d__);
		return <TryLockRefineVisions>d__.<>t__builder.Task;
	}

	// Token: 0x0600AE08 RID: 44552 RVA: 0x0027384F File Offset: 0x00271A4F
	private VisionRecoverySlotGridItem InitVisionRecoverySlotGridItem()
	{
		return new VisionRecoverySlotGridItem(new Action<bool, PhantomItemData>(this.OnClickRewardCallback), false);
	}

	// Token: 0x0600AE09 RID: 44553 RVA: 0x00273863 File Offset: 0x00271A63
	private void OnClickMask()
	{
		base.CloseMe(this.OnCloseCallback);
	}

	// Token: 0x0600AE0A RID: 44554 RVA: 0x00273874 File Offset: 0x00271A74
	private void OnGoToPhantomLevelUp()
	{
		if (this.ItemDataList.Count != 1)
		{
			return;
		}
		VisionIntensifyViewPassData visionIntensifyViewPassData = new VisionIntensifyViewPassData();
		visionIntensifyViewPassData.UniqueId = this.ItemDataList[0].GetUniqueId();
		UiManager.Instance.OpenView(EUiViewName.VisionIntensifyView, visionIntensifyViewPassData, null);
		base.CloseMe(delegate(bool success)
		{
			if (this.OnCloseCallback != null)
			{
				this.OnCloseCallback(success);
			}
		});
	}

	// Token: 0x0600AE0B RID: 44555 RVA: 0x002738D0 File Offset: 0x00271AD0
	[NullableContext(2)]
	private void OnClickRewardCallback(bool isAddVision, PhantomItemData data)
	{
		if (data == null)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemUid(data.GetUniqueId(), data.GetConfigId(), true, null);
	}

	// Token: 0x0600AE0C RID: 44556 RVA: 0x002738EE File Offset: 0x00271AEE
	private void SetTipsState(bool active)
	{
		base.GetItem(5).SetUIActive(active);
		base.GetButton(1).SetSelfInteractive(!active);
	}

	// Token: 0x04004F12 RID: 20242
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRecoverySlotGridItem, PhantomItemData> MainRewardLayout;

	// Token: 0x04004F13 RID: 20243
	private readonly List<PhantomItemData> ItemDataList = new List<PhantomItemData>();

	// Token: 0x04004F14 RID: 20244
	[Nullable(2)]
	public Action<bool> OnCloseCallback;

	// Token: 0x02007D64 RID: 32100
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040290F3 RID: 168179
		ItemVision,
		// Token: 0x040290F4 RID: 168180
		BtnMask,
		// Token: 0x040290F5 RID: 168181
		MainRewardLayout,
		// Token: 0x040290F6 RID: 168182
		ItemTips,
		// Token: 0x040290F7 RID: 168183
		ExtraRewardLayout,
		// Token: 0x040290F8 RID: 168184
		TipItem,
		// Token: 0x040290F9 RID: 168185
		CancelBtn,
		// Token: 0x040290FA RID: 168186
		ConfirmBtn,
		// Token: 0x040290FB RID: 168187
		AttrRoot,
		// Token: 0x040290FC RID: 168188
		AttrTex,
		// Token: 0x040290FD RID: 168189
		AttrText,
		// Token: 0x040290FE RID: 168190
		AttrTipText
	}
}
