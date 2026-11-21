using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200067C RID: 1660
[NullableContext(1)]
[Nullable(0)]
public class CheckInRewardCard : ActivitySubViewBase
{
	// Token: 0x06004CDC RID: 19676 RVA: 0x001A1E3C File Offset: 0x001A003C
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

	// Token: 0x06004CDD RID: 19677 RVA: 0x001A1FEC File Offset: 0x001A01EC
	protected override UniTask OnBeforeStartAsync()
	{
		CheckInRewardCard.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CheckInRewardCard.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004CDE RID: 19678 RVA: 0x001A202F File Offset: 0x001A022F
	protected override void OnStart()
	{
	}

	// Token: 0x06004CDF RID: 19679 RVA: 0x001A2031 File Offset: 0x001A0231
	public void Refresh(TimePointRewardData data)
	{
		this.Data = data;
		this.RefreshItem();
		this.RefreshTxtTime();
		this.RefreshLockedAndReceived();
	}

	// Token: 0x06004CE0 RID: 19680 RVA: 0x001A204C File Offset: 0x001A024C
	private void RefreshItem()
	{
		TimePointRewardActivity? timePointRewardById = ActivityTimePointRewardConfig.Instance.GetTimePointRewardById(this.Data.Id);
		int num = 0;
		foreach (IntPair intPair in timePointRewardById.Value.RewardsIter())
		{
			this.CheckInRewardItems[num++].Refresh(this.Data, intPair.Item1, intPair.Item2);
		}
	}

	// Token: 0x06004CE1 RID: 19681 RVA: 0x001A20DC File Offset: 0x001A02DC
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

	// Token: 0x06004CE2 RID: 19682 RVA: 0x001A21C0 File Offset: 0x001A03C0
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

	// Token: 0x06004CE3 RID: 19683 RVA: 0x001A2434 File Offset: 0x001A0634
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

	// Token: 0x06004CE4 RID: 19684 RVA: 0x001A249D File Offset: 0x001A069D
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

	// Token: 0x04003850 RID: 14416
	[Nullable(2)]
	private TimePointRewardData Data;

	// Token: 0x04003851 RID: 14417
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CheckInRewardItem[] CheckInRewardItems;

	// Token: 0x04003852 RID: 14418
	public Action OnClickAction;

	// Token: 0x04003853 RID: 14419
	private string ItemTexture1Hor = "";

	// Token: 0x04003854 RID: 14420
	private string ItemTexture1Nor = "";

	// Token: 0x04003855 RID: 14421
	private string ItemTexture2Hor = "";

	// Token: 0x04003856 RID: 14422
	private string ItemTexture2Nor = "";

	// Token: 0x04003857 RID: 14423
	private readonly int[] BtnComponentIds = new int[]
	{
		1,
		2
	};

	// Token: 0x02006944 RID: 26948
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022ACB RID: 142027
		Uiltem_Commonhongdian_Prefab,
		// Token: 0x04022ACC RID: 142028
		BtnReward1,
		// Token: 0x04022ACD RID: 142029
		BtnReward2,
		// Token: 0x04022ACE RID: 142030
		TxtTime,
		// Token: 0x04022ACF RID: 142031
		TxtReward,
		// Token: 0x04022AD0 RID: 142032
		BtnWelfare37Card,
		// Token: 0x04022AD1 RID: 142033
		PnlNor,
		// Token: 0x04022AD2 RID: 142034
		PnlReceive,
		// Token: 0x04022AD3 RID: 142035
		PnlFinish,
		// Token: 0x04022AD4 RID: 142036
		PnlFinishBgMask
	}
}
