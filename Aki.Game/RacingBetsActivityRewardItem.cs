using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BF3 RID: 7155
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsActivityRewardItem : GridProxyAbstract<RacingBetsRewardData>
{
	// Token: 0x06011C92 RID: 72850 RVA: 0x0053A9E8 File Offset: 0x00538BE8
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

	// Token: 0x06011C93 RID: 72851 RVA: 0x0053AB30 File Offset: 0x00538D30
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		RacingBetsActivityRewardItem.<OnBeforeShowAsyncImplement>d__4 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RacingBetsActivityRewardItem.<OnBeforeShowAsyncImplement>d__4>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06011C94 RID: 72852 RVA: 0x0053AB74 File Offset: 0x00538D74
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

	// Token: 0x06011C95 RID: 72853 RVA: 0x0053AC48 File Offset: 0x00538E48
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

	// Token: 0x06011C96 RID: 72854 RVA: 0x0053ACE6 File Offset: 0x00538EE6
	private void OnClickJump()
	{
	}

	// Token: 0x06011C97 RID: 72855 RVA: 0x0053ACE8 File Offset: 0x00538EE8
	private void OnClickGetButton()
	{
		RacingBetsController.Instance.RacingBetsTaskRewardRequest(this.RewardData.Id);
	}

	// Token: 0x04009B6B RID: 39787
	private RacingBetsRewardData RewardData;

	// Token: 0x04009B6C RID: 39788
	[Nullable(2)]
	private CommonItemSmallItemGrid RewardIconItem;

	// Token: 0x02007EDC RID: 32476
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040290DA RID: 168154
		DescText,
		// Token: 0x040290DB RID: 168155
		ProgressText,
		// Token: 0x040290DC RID: 168156
		JumpBtn,
		// Token: 0x040290DD RID: 168157
		ReceiveBtn,
		// Token: 0x040290DE RID: 168158
		DoingText,
		// Token: 0x040290DF RID: 168159
		ReceivedSprite,
		// Token: 0x040290E0 RID: 168160
		RewardLayout,
		// Token: 0x040290E1 RID: 168161
		RewardItem,
		// Token: 0x040290E2 RID: 168162
		JumpBtnText,
		// Token: 0x040290E3 RID: 168163
		ReceiveBtnText,
		// Token: 0x040290E4 RID: 168164
		RedDotItem
	}
}
