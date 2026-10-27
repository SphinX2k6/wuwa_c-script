using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002708 RID: 9992
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsActivityRewardItem : GridProxyAbstract<RacingBetsRewardData>
{
	// Token: 0x060147B0 RID: 83888 RVA: 0x0052BCCC File Offset: 0x00529ECC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickJump)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickGetButton))
		};
	}

	// Token: 0x060147B1 RID: 83889 RVA: 0x0052BE14 File Offset: 0x0052A014
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		RacingBetsActivityRewardItem.<OnBeforeShowAsyncImplement>d__4 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RacingBetsActivityRewardItem.<OnBeforeShowAsyncImplement>d__4>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060147B2 RID: 83890 RVA: 0x0052BE58 File Offset: 0x0052A058
	public override void Refresh(RacingBetsRewardData data, bool isSelected, int gridIndex)
	{
		this.RewardData = data;
		List<TItem> rewardList = this.RewardData.GetRewardList();
		if (rewardList.Count > 0)
		{
			CommonItemSmallItemGrid rewardIconItem = this.RewardIconItem;
			if (rewardIconItem != null)
			{
				rewardIconItem.Refresh(rewardList[0]);
			}
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.ShowTextNew(this.RewardData.GetRewardName());
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText(this.RewardData.GetProgressText(), true);
		}
		ConditionTaskStatus taskStatus = this.RewardData.GetTaskStatus();
		this.RefreshState(taskStatus);
		UUIText text3 = base.GetText(8);
		if (text3 != null)
		{
			text3.ShowTextNew("Dango_CurrencyPage_Status_1");
		}
		UUIText text4 = base.GetText(4);
		if (text4 != null)
		{
			text4.ShowTextNew("Dango_CurrencyPage_Status_2");
		}
		UUIText text5 = base.GetText(9);
		if (text5 == null)
		{
			return;
		}
		text5.ShowTextNew("Dango_CurrencyPage_Status_3");
	}

	// Token: 0x060147B3 RID: 83891 RVA: 0x0052BF2C File Offset: 0x0052A12C
	public void RefreshState(ConditionTaskStatus rewardStatus)
	{
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(rewardStatus == ConditionTaskStatus.TaskFinish);
			}
		}
		UUIButtonComponent button2 = base.GetButton(2);
		if (button2 != null)
		{
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(false);
			}
		}
		UUIText text = base.GetText(4);
		if (text != null)
		{
			text.SetUIActive(rewardStatus == ConditionTaskStatus.Undone);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(rewardStatus == ConditionTaskStatus.Received);
		}
		UUIItem item = base.GetItem(10);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(rewardStatus == ConditionTaskStatus.TaskFinish);
	}

	// Token: 0x060147B4 RID: 83892 RVA: 0x0052BFCA File Offset: 0x0052A1CA
	private void OnClickJump()
	{
	}

	// Token: 0x060147B5 RID: 83893 RVA: 0x0052BFCC File Offset: 0x0052A1CC
	private void OnClickGetButton()
	{
		RacingBetsController.Instance.RacingBetsTaskRewardRequest(this.RewardData.Id);
	}

	// Token: 0x04009A13 RID: 39443
	private RacingBetsRewardData RewardData;

	// Token: 0x04009A14 RID: 39444
	[Nullable(2)]
	private CommonItemSmallItemGrid RewardIconItem;

	// Token: 0x02008D53 RID: 36179
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402DDC3 RID: 187843
		DescText,
		// Token: 0x0402DDC4 RID: 187844
		ProgressText,
		// Token: 0x0402DDC5 RID: 187845
		JumpBtn,
		// Token: 0x0402DDC6 RID: 187846
		ReceiveBtn,
		// Token: 0x0402DDC7 RID: 187847
		DoingText,
		// Token: 0x0402DDC8 RID: 187848
		ReceivedSprite,
		// Token: 0x0402DDC9 RID: 187849
		RewardLayout,
		// Token: 0x0402DDCA RID: 187850
		RewardItem,
		// Token: 0x0402DDCB RID: 187851
		JumpBtnText,
		// Token: 0x0402DDCC RID: 187852
		ReceiveBtnText,
		// Token: 0x0402DDCD RID: 187853
		RedDotItem
	}
}
