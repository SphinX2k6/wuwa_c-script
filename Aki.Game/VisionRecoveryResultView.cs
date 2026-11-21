using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C14 RID: 3092
[NullableContext(1)]
[Nullable(0)]
public class VisionRecoveryResultView : UiViewBase
{
	// Token: 0x060080EB RID: 33003 RVA: 0x002789D6 File Offset: 0x00276BD6
	public VisionRecoveryResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060080EC RID: 33004 RVA: 0x002789EC File Offset: 0x00276BEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickCloseBtn))
		};
	}

	// Token: 0x060080ED RID: 33005 RVA: 0x00278AAC File Offset: 0x00276CAC
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoveryResultView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoveryResultView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060080EE RID: 33006 RVA: 0x00278AF0 File Offset: 0x00276CF0
	private void RefreshRecoverySlotPanel(IReadOnlyList<PhantomItem> costPhantoms)
	{
		InventoryModel instance = InventoryModel.Instance;
		List<PhantomItemData> list = new List<PhantomItemData>();
		foreach (PhantomItem phantomItem in costPhantoms)
		{
			if (list.Count >= 5)
			{
				break;
			}
			PhantomItemData phantomItemDataByPhantomItem = instance.GetPhantomItemDataByPhantomItem(phantomItem);
			int stackUnitCount = PhantomStackUtil.GetStackUnitCount(phantomItem.StackCount);
			int num = 0;
			while (num < stackUnitCount && list.Count < 5)
			{
				list.Add(phantomItemDataByPhantomItem);
				num++;
			}
		}
		this.RecoverySlotPanel.RefreshUi(list);
	}

	// Token: 0x060080EF RID: 33007 RVA: 0x00278B8C File Offset: 0x00276D8C
	private void RefreshMainReward(IReadOnlyList<AddCountItemInfo> items)
	{
		List<PhantomItemData> phantomItemDataListByAddCountItemInfo = InventoryModel.Instance.GetPhantomItemDataListByAddCountItemInfo(items);
		if (phantomItemDataListByAddCountItemInfo.Count <= 0)
		{
			Log.Instance.Info(ELogModule.Calabash, ELogAuthor.BB, "VisionRecoveryResultView 主奖励为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.MainRewardVision.RefreshUi(phantomItemDataListByAddCountItemInfo[0]);
	}

	// Token: 0x060080F0 RID: 33008 RVA: 0x00278BE0 File Offset: 0x00276DE0
	private UniTask RefreshSubReward(IReadOnlyList<AddCountItemInfo> items)
	{
		VisionRecoveryResultView.<RefreshSubReward>d__9 <RefreshSubReward>d__;
		<RefreshSubReward>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubReward>d__.<>4__this = this;
		<RefreshSubReward>d__.items = items;
		<RefreshSubReward>d__.<>1__state = -1;
		<RefreshSubReward>d__.<>t__builder.Start<VisionRecoveryResultView.<RefreshSubReward>d__9>(ref <RefreshSubReward>d__);
		return <RefreshSubReward>d__.<>t__builder.Task;
	}

	// Token: 0x060080F1 RID: 33009 RVA: 0x00278C2C File Offset: 0x00276E2C
	private void BindStartAnimationCallBack(IReadOnlyList<AddCountItemInfo> items)
	{
		if (items.Count <= 0)
		{
			return;
		}
		this.UiViewSequence.AddSequenceFinishEvent("Start", delegate(string _)
		{
			UiNavigationNewController.Instance.RepeatCursorMove();
			switch (items.Count)
			{
			case 1:
				this.UiViewSequence.PlaySequence("RewardA", false, null);
				return;
			case 2:
				this.UiViewSequence.PlaySequence("RewardB", false, null);
				return;
			case 3:
				this.UiViewSequence.PlaySequence("RewardC", false, null);
				return;
			case 4:
				this.UiViewSequence.PlaySequence("RewardD", false, null);
				return;
			default:
				this.UiViewSequence.PlaySequence("RewardD", false, null);
				return;
			}
		}, false);
	}

	// Token: 0x060080F2 RID: 33010 RVA: 0x00278C79 File Offset: 0x00276E79
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x060080F3 RID: 33011 RVA: 0x00278C82 File Offset: 0x00276E82
	[NullableContext(2)]
	private void OnClickRewardCallback(bool isAddVision, PhantomItemData data)
	{
		if (data == null)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemUid(data.GetUniqueId(), data.GetConfigId(), true, null);
	}

	// Token: 0x04004F59 RID: 20313
	[Nullable(2)]
	private VisionRecoverySlotPanel RecoverySlotPanel;

	// Token: 0x04004F5A RID: 20314
	[Nullable(2)]
	private VisionRecoverySlotItem MainRewardVision;

	// Token: 0x04004F5B RID: 20315
	private readonly List<VisionRecoverySlotItem> SubRewardVisionList = new List<VisionRecoverySlotItem>();

	// Token: 0x02006EC7 RID: 28359
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024367 RID: 148327
		RecoverySlotPanel,
		// Token: 0x04024368 RID: 148328
		RecoveryMainReward,
		// Token: 0x04024369 RID: 148329
		RecoverySubRewardRoot,
		// Token: 0x0402436A RID: 148330
		RecoverySubRewardItemRoot,
		// Token: 0x0402436B RID: 148331
		RecoverySubRewardItem,
		// Token: 0x0402436C RID: 148332
		MaskBtn
	}
}
