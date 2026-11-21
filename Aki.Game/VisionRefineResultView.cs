using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C2A RID: 3114
[NullableContext(1)]
[Nullable(0)]
public class VisionRefineResultView : UiViewBase
{
	// Token: 0x060081EA RID: 33258 RVA: 0x0027DA43 File Offset: 0x0027BC43
	public VisionRefineResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060081EB RID: 33259 RVA: 0x0027DA58 File Offset: 0x0027BC58
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

	// Token: 0x060081EC RID: 33260 RVA: 0x0027DBD0 File Offset: 0x0027BDD0
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineResultView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineResultView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060081ED RID: 33261 RVA: 0x0027DC14 File Offset: 0x0027BE14
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

	// Token: 0x060081EE RID: 33262 RVA: 0x0027DCC8 File Offset: 0x0027BEC8
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

	// Token: 0x060081EF RID: 33263 RVA: 0x0027DD13 File Offset: 0x0027BF13
	private VisionRecoverySlotGridItem InitVisionRecoverySlotGridItem()
	{
		return new VisionRecoverySlotGridItem(new Action<bool, PhantomItemData>(this.OnClickRewardCallback), false);
	}

	// Token: 0x060081F0 RID: 33264 RVA: 0x0027DD27 File Offset: 0x0027BF27
	private void OnClickMask()
	{
		base.CloseMe(this.OnCloseCallback);
	}

	// Token: 0x060081F1 RID: 33265 RVA: 0x0027DD38 File Offset: 0x0027BF38
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

	// Token: 0x060081F2 RID: 33266 RVA: 0x0027DD94 File Offset: 0x0027BF94
	[NullableContext(2)]
	private void OnClickRewardCallback(bool isAddVision, PhantomItemData data)
	{
		if (data == null)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemUid(data.GetUniqueId(), data.GetConfigId(), true, null);
	}

	// Token: 0x060081F3 RID: 33267 RVA: 0x0027DDB2 File Offset: 0x0027BFB2
	private void SetTipsState(bool active)
	{
		base.GetItem(5).SetUIActive(active);
		base.GetButton(1).SetSelfInteractive(!active);
	}

	// Token: 0x04004FBC RID: 20412
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRecoverySlotGridItem, PhantomItemData> MainRewardLayout;

	// Token: 0x04004FBD RID: 20413
	private readonly List<PhantomItemData> ItemDataList = new List<PhantomItemData>();

	// Token: 0x04004FBE RID: 20414
	[Nullable(2)]
	public Action<bool> OnCloseCallback;

	// Token: 0x02006EEA RID: 28394
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402441E RID: 148510
		ItemVision,
		// Token: 0x0402441F RID: 148511
		BtnMask,
		// Token: 0x04024420 RID: 148512
		MainRewardLayout,
		// Token: 0x04024421 RID: 148513
		ItemTips,
		// Token: 0x04024422 RID: 148514
		ExtraRewardLayout,
		// Token: 0x04024423 RID: 148515
		TipItem,
		// Token: 0x04024424 RID: 148516
		CancelBtn,
		// Token: 0x04024425 RID: 148517
		ConfirmBtn,
		// Token: 0x04024426 RID: 148518
		AttrRoot,
		// Token: 0x04024427 RID: 148519
		AttrTex,
		// Token: 0x04024428 RID: 148520
		AttrText,
		// Token: 0x04024429 RID: 148521
		AttrTipText
	}
}
