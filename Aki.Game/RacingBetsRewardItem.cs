using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002720 RID: 10016
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsRewardItem : GridProxyAbstract<RacingBetsRewardData>
{
	// Token: 0x06014868 RID: 84072 RVA: 0x0052EAFC File Offset: 0x0052CCFC
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

	// Token: 0x06014869 RID: 84073 RVA: 0x0052EC14 File Offset: 0x0052CE14
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		RacingBetsRewardItem.<OnBeforeShowAsyncImplement>d__5 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<RacingBetsRewardItem.<OnBeforeShowAsyncImplement>d__5>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0601486A RID: 84074 RVA: 0x0052EC58 File Offset: 0x0052CE58
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

	// Token: 0x0601486B RID: 84075 RVA: 0x0052ED2C File Offset: 0x0052CF2C
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

	// Token: 0x0601486C RID: 84076 RVA: 0x0052EDCA File Offset: 0x0052CFCA
	public void BindClickGetButtonCallBack(Action callback)
	{
		this.ClickGetButtonCallback = callback;
	}

	// Token: 0x0601486D RID: 84077 RVA: 0x0052EDD3 File Offset: 0x0052CFD3
	private void OnClickGetButton()
	{
		Action clickGetButtonCallback = this.ClickGetButtonCallback;
		if (clickGetButtonCallback == null)
		{
			return;
		}
		clickGetButtonCallback();
	}

	// Token: 0x04009A5D RID: 39517
	private RacingBetsRewardData RewardData;

	// Token: 0x04009A5E RID: 39518
	[Nullable(2)]
	private CommonItemSmallItemGrid RewardIconItem;

	// Token: 0x04009A5F RID: 39519
	private Action ClickGetButtonCallback = delegate()
	{
	};

	// Token: 0x02008D73 RID: 36211
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402DE54 RID: 187988
		RewardItem,
		// Token: 0x0402DE55 RID: 187989
		DescText,
		// Token: 0x0402DE56 RID: 187990
		ProgressText,
		// Token: 0x0402DE57 RID: 187991
		JumpBtn,
		// Token: 0x0402DE58 RID: 187992
		ReceiveBtn,
		// Token: 0x0402DE59 RID: 187993
		DoingText,
		// Token: 0x0402DE5A RID: 187994
		ReceivedSprite,
		// Token: 0x0402DE5B RID: 187995
		JumpBtnText,
		// Token: 0x0402DE5C RID: 187996
		ReceiveBtnText,
		// Token: 0x0402DE5D RID: 187997
		RedDotItem
	}
}
