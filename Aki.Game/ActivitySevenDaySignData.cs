using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020014F8 RID: 5368
[NullableContext(2)]
[Nullable(0)]
public class ActivitySevenDaySignData : ActivityBaseData
{
	// Token: 0x06009923 RID: 39203 RVA: 0x00211FE4 File Offset: 0x002101E4
	[NullableContext(1)]
	protected unsafe override void PhraseEx(ActivityData data)
	{
		this.DayRewardStateList = data.SignActivity.SignStateList.ToList<SignState>();
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

	// Token: 0x06009924 RID: 39204 RVA: 0x00212093 File Offset: 0x00210293
	protected override bool GetExDataFinishShowState()
	{
		return this.IsAllSignRewardReceived();
	}

	// Token: 0x06009925 RID: 39205 RVA: 0x0021209B File Offset: 0x0021029B
	public bool IsAllSignRewardReceived()
	{
		if (this.DayRewardStateList == null)
		{
			return false;
		}
		return !this.DayRewardStateList.Any((SignState state) => state != SignState.IsReceive);
	}

	// Token: 0x06009926 RID: 39206 RVA: 0x002120D4 File Offset: 0x002102D4
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

	// Token: 0x06009927 RID: 39207 RVA: 0x0021212C File Offset: 0x0021032C
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

	// Token: 0x06009928 RID: 39208 RVA: 0x00212208 File Offset: 0x00210408
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

	// Token: 0x06009929 RID: 39209 RVA: 0x002122B0 File Offset: 0x002104B0
	public void SetRewardToGotState(int day)
	{
		this.DayRewardStateList[day] = SignState.IsReceive;
	}

	// Token: 0x0600992A RID: 39210 RVA: 0x002122C0 File Offset: 0x002104C0
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

	// Token: 0x0600992B RID: 39211 RVA: 0x00212300 File Offset: 0x00210500
	public string GetBigRewardIcon(int actId)
	{
		ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(actId);
		if (activitySignById == null)
		{
			return null;
		}
		return activitySignById.GetValueOrDefault().ImportantRewardIcon;
	}

	// Token: 0x0600992C RID: 39212 RVA: 0x00212333 File Offset: 0x00210533
	public SignState? GetRewardStateByDay(int day)
	{
		return new SignState?(this.DayRewardStateList[day]);
	}

	// Token: 0x0600992D RID: 39213 RVA: 0x00212348 File Offset: 0x00210548
	public int GetImportantItemIndex()
	{
		ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(base.Id);
		if (activitySignById != null)
		{
			return activitySignById.Value.ImportantRewardIndex;
		}
		return 0;
	}

	// Token: 0x0600992E RID: 39214 RVA: 0x00212380 File Offset: 0x00210580
	public int GetImportantRewardType()
	{
		ActivitySign? activitySignById = ActivitySevenDaySignConfig.Instance.GetActivitySignById(base.Id);
		if (activitySignById == null)
		{
			return 0;
		}
		return activitySignById.Value.ImportantRewardType;
	}

	// Token: 0x0600992F RID: 39215 RVA: 0x002123B8 File Offset: 0x002105B8
	public void SetFreeRewardIsGet(bool value)
	{
		this.RewardFreeIsGet = value;
	}

	// Token: 0x06009930 RID: 39216 RVA: 0x002123C1 File Offset: 0x002105C1
	public bool GetFreeRewardIsGet()
	{
		return this.RewardFreeIsGet;
	}

	// Token: 0x04004357 RID: 17239
	private List<SignState> DayRewardStateList;

	// Token: 0x04004358 RID: 17240
	private bool RewardFreeIsGet;
}
