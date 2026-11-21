using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C0B RID: 7179
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsRewardItem : GridProxyAbstract<RacingBetsRewardData>
{
	// Token: 0x06011D4A RID: 73034 RVA: 0x0053D818 File Offset: 0x0053BA18
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickGetButton))
		};
	}

	// Token: 0x06011D4B RID: 73035 RVA: 0x0053D930 File Offset: 0x0053BB30
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		RacingBetsRewardItem.<OnBeforeShowAsyncImplement>d__5 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RacingBetsRewardItem.<OnBeforeShowAsyncImplement>d__5>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06011D4C RID: 73036 RVA: 0x0053D974 File Offset: 0x0053BB74
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
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(this.RewardData.GetRewardName());
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetText(this.RewardData.GetProgressText(), true);
		}
		ConditionTaskStatus taskStatus = this.RewardData.GetTaskStatus();
		this.RefreshState(taskStatus);
		UUIText text3 = base.GetText(7);
		if (text3 != null)
		{
			text3.ShowTextNew("Dango_CurrencyPage_Status_1");
		}
		UUIText text4 = base.GetText(5);
		if (text4 != null)
		{
			text4.ShowTextNew("Dango_CurrencyPage_Status_2");
		}
		UUIText text5 = base.GetText(8);
		if (text5 == null)
		{
			return;
		}
		text5.ShowTextNew("Dango_CurrencyPage_Status_3");
	}

	// Token: 0x06011D4D RID: 73037 RVA: 0x0053DA48 File Offset: 0x0053BC48
	private void RefreshState(ConditionTaskStatus rewardStatus)
	{
		UUIButtonComponent button = base.GetButton(4);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(rewardStatus == ConditionTaskStatus.TaskFinish);
			}
		}
		UUIButtonComponent button2 = base.GetButton(3);
		if (button2 != null)
		{
			UUIItem uuiitem2 = button2.RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(false);
			}
		}
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetUIActive(rewardStatus == ConditionTaskStatus.Undone);
		}
		UUISprite sprite = base.GetSprite(6);
		if (sprite != null)
		{
			sprite.SetUIActive(rewardStatus == ConditionTaskStatus.Received);
		}
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(rewardStatus == ConditionTaskStatus.TaskFinish);
	}

	// Token: 0x06011D4E RID: 73038 RVA: 0x0053DAE6 File Offset: 0x0053BCE6
	public void BindClickGetButtonCallBack(Action callback)
	{
		this.ClickGetButtonCallback = callback;
	}

	// Token: 0x06011D4F RID: 73039 RVA: 0x0053DAEF File Offset: 0x0053BCEF
	private void OnClickGetButton()
	{
		Action clickGetButtonCallback = this.ClickGetButtonCallback;
		if (clickGetButtonCallback == null)
		{
			return;
		}
		clickGetButtonCallback();
	}

	// Token: 0x04009BB5 RID: 39861
	private RacingBetsRewardData RewardData;

	// Token: 0x04009BB6 RID: 39862
	[Nullable(2)]
	private CommonItemSmallItemGrid RewardIconItem;

	// Token: 0x04009BB7 RID: 39863
	private Action ClickGetButtonCallback = delegate()
	{
	};

	// Token: 0x02007EFC RID: 32508
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402916B RID: 168299
		RewardItem,
		// Token: 0x0402916C RID: 168300
		DescText,
		// Token: 0x0402916D RID: 168301
		ProgressText,
		// Token: 0x0402916E RID: 168302
		JumpBtn,
		// Token: 0x0402916F RID: 168303
		ReceiveBtn,
		// Token: 0x04029170 RID: 168304
		DoingText,
		// Token: 0x04029171 RID: 168305
		ReceivedSprite,
		// Token: 0x04029172 RID: 168306
		JumpBtnText,
		// Token: 0x04029173 RID: 168307
		ReceiveBtnText,
		// Token: 0x04029174 RID: 168308
		RedDotItem
	}
}
