using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011C8 RID: 4552
[NullableContext(1)]
[Nullable(0)]
public class CheckInRewardCard : ActivitySubViewBase
{
	// Token: 0x06007945 RID: 31045 RVA: 0x0019918C File Offset: 0x0019738C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickedButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007946 RID: 31046 RVA: 0x0019933C File Offset: 0x0019753C
	protected override UniTask OnBeforeStartAsync()
	{
		CheckInRewardCard.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CheckInRewardCard.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007947 RID: 31047 RVA: 0x0019937F File Offset: 0x0019757F
	protected override void OnStart()
	{
	}

	// Token: 0x06007948 RID: 31048 RVA: 0x00199381 File Offset: 0x00197581
	public void Refresh(TimePointRewardData data)
	{
		this.Data = data;
		this.RefreshItem();
		this.RefreshTxtTime();
		this.RefreshLockedAndReceived();
	}

	// Token: 0x06007949 RID: 31049 RVA: 0x0019939C File Offset: 0x0019759C
	private void RefreshItem()
	{
		TimePointRewardActivity? timePointRewardById = ActivityTimePointRewardConfig.Instance.GetTimePointRewardById(this.Data.Id);
		int num = 0;
		foreach (IntPair intPair in timePointRewardById.Value.RewardsIter())
		{
			this.CheckInRewardItems[num++].Refresh(this.Data, intPair.Item1, intPair.Item2);
		}
	}

	// Token: 0x0600794A RID: 31050 RVA: 0x0019942C File Offset: 0x0019762C
	private void RefreshTxtTime()
	{
		int currentCheckInCount = this.Data.CurrentCheckInCount;
		int conditionCount = this.Data.ConditionCount;
		string newText;
		if (currentCheckInCount < conditionCount)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted("#bcbcbc");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<int>(currentCheckInCount);
			defaultInterpolatedStringHandler.AppendLiteral("</color>/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(conditionCount);
			newText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted("#ffffff");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<int>(conditionCount);
			defaultInterpolatedStringHandler.AppendLiteral("</color>/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(conditionCount);
			newText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		base.GetText(3).SetText(newText, true);
	}

	// Token: 0x0600794B RID: 31051 RVA: 0x00199510 File Offset: 0x00197710
	private void RefreshLockedAndReceived()
	{
		TimePointRewardData data = this.Data;
		ETimePointRewardState? etimePointRewardState = (data != null) ? new ETimePointRewardState?(data.RewardState) : null;
		if (etimePointRewardState == null)
		{
			return;
		}
		switch (etimePointRewardState.GetValueOrDefault())
		{
		case ETimePointRewardState.Lock:
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(8);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(9);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
			UUIItem item5 = base.GetItem(0);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
			this.CheckInRewardItems[0].SetTextIcon(this.ItemTexture1Nor);
			this.CheckInRewardItems[1].SetTextIcon(this.ItemTexture2Nor);
			UUIButtonComponent button = base.GetButton(5);
			if (button != null)
			{
				button.SetSelfInteractive(false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "SecretText1", Array.Empty<object>());
			return;
		}
		case ETimePointRewardState.UnlockAndUnClaimed:
		{
			UUIItem item6 = base.GetItem(6);
			if (item6 != null)
			{
				item6.SetUIActive(false);
			}
			UUIItem item7 = base.GetItem(7);
			if (item7 != null)
			{
				item7.SetUIActive(true);
			}
			UUIItem item8 = base.GetItem(8);
			if (item8 != null)
			{
				item8.SetUIActive(false);
			}
			UUIItem item9 = base.GetItem(9);
			if (item9 != null)
			{
				item9.SetUIActive(false);
			}
			UUIItem item10 = base.GetItem(0);
			if (item10 != null)
			{
				item10.SetUIActive(true);
			}
			this.CheckInRewardItems[0].SetTextIcon(this.ItemTexture1Hor);
			this.CheckInRewardItems[1].SetTextIcon(this.ItemTexture2Hor);
			UUIButtonComponent button2 = base.GetButton(5);
			if (button2 != null)
			{
				button2.SetSelfInteractive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "SecretText2", Array.Empty<object>());
			return;
		}
		case ETimePointRewardState.UnlockAndClaimed:
		{
			UUIItem item11 = base.GetItem(6);
			if (item11 != null)
			{
				item11.SetUIActive(false);
			}
			UUIItem item12 = base.GetItem(7);
			if (item12 != null)
			{
				item12.SetUIActive(false);
			}
			UUIItem item13 = base.GetItem(8);
			if (item13 != null)
			{
				item13.SetUIActive(true);
			}
			UUIItem item14 = base.GetItem(9);
			if (item14 != null)
			{
				item14.SetUIActive(true);
			}
			UUIItem item15 = base.GetItem(0);
			if (item15 != null)
			{
				item15.SetUIActive(false);
			}
			this.CheckInRewardItems[0].SetTextIcon(this.ItemTexture1Nor);
			this.CheckInRewardItems[1].SetTextIcon(this.ItemTexture2Nor);
			UUIButtonComponent button3 = base.GetButton(5);
			if (button3 != null)
			{
				button3.SetSelfInteractive(false);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "SecretText3", Array.Empty<object>());
			return;
		}
		default:
			return;
		}
	}

	// Token: 0x0600794C RID: 31052 RVA: 0x00199784 File Offset: 0x00197984
	public void SetItemTexturePath(int cardIndex = 0)
	{
		if (cardIndex == 0)
		{
			this.ItemTexture1Hor = "T_Welfare37Icon01Hor";
			this.ItemTexture1Nor = "T_Welfare37Icon01Nor";
			this.ItemTexture2Hor = "T_Welfare37Icon02Hor";
			this.ItemTexture2Nor = "T_Welfare37Icon02Nor";
			return;
		}
		this.ItemTexture1Hor = "T_Welfare37Icon01Hor";
		this.ItemTexture1Nor = "T_Welfare37Icon01Nor";
		this.ItemTexture2Hor = "T_Welfare37Icon03Hor";
		this.ItemTexture2Nor = "T_Welfare37Icon03Nor";
	}

	// Token: 0x0600794D RID: 31053 RVA: 0x001997ED File Offset: 0x001979ED
	private void OnClickedButton()
	{
		TimePointRewardData data = this.Data;
		if (data != null && data.RewardState == ETimePointRewardState.UnlockAndUnClaimed)
		{
			Action onClickAction = this.OnClickAction;
			if (onClickAction == null)
			{
				return;
			}
			onClickAction();
		}
	}

	// Token: 0x040037B7 RID: 14263
	[Nullable(2)]
	private TimePointRewardData Data;

	// Token: 0x040037B8 RID: 14264
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CheckInRewardItem[] CheckInRewardItems;

	// Token: 0x040037B9 RID: 14265
	public Action OnClickAction;

	// Token: 0x040037BA RID: 14266
	private string ItemTexture1Hor = "";

	// Token: 0x040037BB RID: 14267
	private string ItemTexture1Nor = "";

	// Token: 0x040037BC RID: 14268
	private string ItemTexture2Hor = "";

	// Token: 0x040037BD RID: 14269
	private string ItemTexture2Nor = "";

	// Token: 0x040037BE RID: 14270
	private readonly int[] BtnComponentIds = new int[]
	{
		1,
		2
	};

	// Token: 0x020077B9 RID: 30649
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027799 RID: 161689
		Uiltem_Commonhongdian_Prefab,
		// Token: 0x0402779A RID: 161690
		BtnReward1,
		// Token: 0x0402779B RID: 161691
		BtnReward2,
		// Token: 0x0402779C RID: 161692
		TxtTime,
		// Token: 0x0402779D RID: 161693
		TxtReward,
		// Token: 0x0402779E RID: 161694
		BtnWelfare37Card,
		// Token: 0x0402779F RID: 161695
		PnlNor,
		// Token: 0x040277A0 RID: 161696
		PnlReceive,
		// Token: 0x040277A1 RID: 161697
		PnlFinish,
		// Token: 0x040277A2 RID: 161698
		PnlFinishBgMask
	}
}
