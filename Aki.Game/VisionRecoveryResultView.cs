using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200175B RID: 5979
[NullableContext(1)]
[Nullable(0)]
public class VisionRecoveryResultView : UiViewBase
{
	// Token: 0x0600AD04 RID: 44292 RVA: 0x0026E55A File Offset: 0x0026C75A
	public VisionRecoveryResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AD05 RID: 44293 RVA: 0x0026E570 File Offset: 0x0026C770
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

	// Token: 0x0600AD06 RID: 44294 RVA: 0x0026E630 File Offset: 0x0026C830
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoveryResultView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoveryResultView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AD07 RID: 44295 RVA: 0x0026E674 File Offset: 0x0026C874
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

	// Token: 0x0600AD08 RID: 44296 RVA: 0x0026E710 File Offset: 0x0026C910
	private void RefreshMainReward(IReadOnlyList<AddCountItemInfo> items)
	{
		List<PhantomItemData> phantomItemDataListByAddCountItemInfo = InventoryModel.Instance.GetPhantomItemDataListByAddCountItemInfo(items.ToList<AddCountItemInfo>());
		if (phantomItemDataListByAddCountItemInfo.Count <= 0)
		{
			Log.Instance.Info(ELogModule.Calabash, ELogAuthor.BB, "VisionRecoveryResultView 主奖励为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.MainRewardVision.RefreshUi(phantomItemDataListByAddCountItemInfo[0]);
	}

	// Token: 0x0600AD09 RID: 44297 RVA: 0x0026E76C File Offset: 0x0026C96C
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

	// Token: 0x0600AD0A RID: 44298 RVA: 0x0026E7B8 File Offset: 0x0026C9B8
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

	// Token: 0x0600AD0B RID: 44299 RVA: 0x0026E805 File Offset: 0x0026CA05
	private void OnClickCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600AD0C RID: 44300 RVA: 0x0026E80E File Offset: 0x0026CA0E
	[NullableContext(2)]
	private void OnClickRewardCallback(bool isAddVision, PhantomItemData data)
	{
		if (data == null)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemUid(data.GetUniqueId(), data.GetConfigId(), true, null);
	}

	// Token: 0x04004EB0 RID: 20144
	[Nullable(2)]
	private VisionRecoverySlotPanel RecoverySlotPanel;

	// Token: 0x04004EB1 RID: 20145
	[Nullable(2)]
	private VisionRecoverySlotItem MainRewardVision;

	// Token: 0x04004EB2 RID: 20146
	private readonly List<VisionRecoverySlotItem> SubRewardVisionList = new List<VisionRecoverySlotItem>();

	// Token: 0x02007D41 RID: 32065
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402903C RID: 167996
		RecoverySlotPanel,
		// Token: 0x0402903D RID: 167997
		RecoveryMainReward,
		// Token: 0x0402903E RID: 167998
		RecoverySubRewardRoot,
		// Token: 0x0402903F RID: 167999
		RecoverySubRewardItemRoot,
		// Token: 0x04029040 RID: 168000
		RecoverySubRewardItem,
		// Token: 0x04029041 RID: 168001
		MaskBtn
	}
}
