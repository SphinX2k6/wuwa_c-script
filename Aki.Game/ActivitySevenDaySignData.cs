using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020009B0 RID: 2480
[NullableContext(2)]
[Nullable(0)]
public class ActivitySevenDaySignData : ActivityBaseData
{
	// Token: 0x06006CFD RID: 27901 RVA: 0x0021BCD4 File Offset: 0x00219ED4
	[NullableContext(1)]
	protected unsafe override void PhraseEx(ActivityData data)
	{
		this.DayRewardStateList = new List<SignState>(data.SignActivity.SignStateList);
		this.RewardFreeIsGet = data.SignActivity.RewardFree;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Activity;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[ActivitySevenDaySign][Phrase]签到活动签到状态打印";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActivityId", base.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SignStateList", this.DayRewardStateList);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, base.Id);
	}

	// Token: 0x06006CFE RID: 27902 RVA: 0x0021BD83 File Offset: 0x00219F83
	protected override bool GetExDataFinishShowState()
	{
		return this.IsAllSignRewardReceived();
	}

	// Token: 0x06006CFF RID: 27903 RVA: 0x0021BD8C File Offset: 0x00219F8C
	public bool IsAllSignRewardReceived()
	{
		if (this.DayRewardStateList == null)
		{
			return false;
		}
		using (List<SignState>.Enumerator enumerator = this.DayRewardStateList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current != SignState.IsReceive)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06006D00 RID: 27904 RVA: 0x0021BDEC File Offset: 0x00219FEC
	public override bool GetExDataRedPointShowState()
	{
		using (List<SignState>.Enumerator enumerator = this.DayRewardStateList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == SignState.Unlock)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06006D01 RID: 27905 RVA: 0x0021BE44 File Offset: 0x0021A044
	[NullableContext(1)]
	public unsafe void UpdateActivityData(SignActivitySignStateNotify notify)
	{
		this.DayRewardStateList[notify.Index] = notify.SignState;
		this.CheckGrandRewardRefresh(notify.Index);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Activity;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[ActivitySevenDaySign][UpdateData]签到活动签到状态改变";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActivityId", base.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SignIndex", notify.Index);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("SignState", notify.SignState);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("SignStateList", this.DayRewardStateList);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
	}

	// Token: 0x06006D02 RID: 27906 RVA: 0x0021BF20 File Offset: 0x0021A120
	public void CheckGrandRewardRefresh(int day)
	{
		ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(base.Id);
		if (activitySignById == null || activitySignById.Value.GrandRewardIdLength <= 0)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < activitySignById.Value.GrandRewardIdLength; i++)
		{
			ActivitySignGrandReward? byId = ActivitySignGrandRewardConfig.Instance.GetById(activitySignById.Value.GrandRewardId(i));
			if (byId != null && byId.Value.GrandRewardIndex - 1 == day)
			{
				num = i;
				break;
			}
		}
		if (num != -1)
		{
			EventSystem.Instance.Emit(EEventName.ActivitySignGrandRewardRefresh);
		}
	}

	// Token: 0x06006D03 RID: 27907 RVA: 0x0021BFC8 File Offset: 0x0021A1C8
	public void SetRewardToGotState(int day)
	{
		this.DayRewardStateList[day] = SignState.IsReceive;
	}

	// Token: 0x06006D04 RID: 27908 RVA: 0x0021BFD8 File Offset: 0x0021A1D8
	public OneItemConfig[] GetRewardByDay(int day)
	{
		OneItemConfig? activityRewardByDay = ActivitySevenDaySignConfig.Instance.GetActivityRewardByDay(base.Id, day);
		if (activityRewardByDay == null)
		{
			return null;
		}
		return new OneItemConfig[]
		{
			activityRewardByDay.Value
		};
	}

	// Token: 0x06006D05 RID: 27909 RVA: 0x0021C018 File Offset: 0x0021A218
	public string GetBigRewardIcon(int actId)
	{
		ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(actId);
		if (activitySignById == null)
		{
			return null;
		}
		return activitySignById.GetValueOrDefault().ImportantRewardIcon;
	}

	// Token: 0x06006D06 RID: 27910 RVA: 0x0021C04B File Offset: 0x0021A24B
	public SignState? GetRewardStateByDay(int day)
	{
		return new SignState?(this.DayRewardStateList[day]);
	}

	// Token: 0x06006D07 RID: 27911 RVA: 0x0021C060 File Offset: 0x0021A260
	public int GetImportantItemIndex()
	{
		ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(base.Id);
		if (activitySignById != null)
		{
			return activitySignById.Value.ImportantRewardIndex;
		}
		return 0;
	}

	// Token: 0x06006D08 RID: 27912 RVA: 0x0021C098 File Offset: 0x0021A298
	public int GetImportantRewardType()
	{
		ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(base.Id);
		if (activitySignById == null)
		{
			return 0;
		}
		return activitySignById.Value.ImportantRewardType;
	}

	// Token: 0x06006D09 RID: 27913 RVA: 0x0021C0D0 File Offset: 0x0021A2D0
	public void SetFreeRewardIsGet(bool value)
	{
		this.RewardFreeIsGet = value;
	}

	// Token: 0x06006D0A RID: 27914 RVA: 0x0021C0D9 File Offset: 0x0021A2D9
	public bool GetFreeRewardIsGet()
	{
		return this.RewardFreeIsGet;
	}

	// Token: 0x040043FC RID: 17404
	private List<SignState> DayRewardStateList;

	// Token: 0x040043FD RID: 17405
	private bool RewardFreeIsGet;
}
