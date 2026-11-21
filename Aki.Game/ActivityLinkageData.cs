using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000574 RID: 1396
[NullableContext(1)]
[Nullable(0)]
public class ActivityLinkageData : ActivityBaseData
{
	// Token: 0x17000994 RID: 2452
	// (get) Token: 0x0600433E RID: 17214 RVA: 0x00174492 File Offset: 0x00172692
	public Dictionary<int, ActivityLinkageTabData> TabDataMap { get; } = new Dictionary<int, ActivityLinkageTabData>();

	// Token: 0x0600433F RID: 17215 RVA: 0x0017449C File Offset: 0x0017269C
	protected override void PhraseEx(ActivityData data)
	{
		Aki.Protocol.ActivityLinkageData activityLinkageData = data.ActivityLinkageData;
		if (activityLinkageData == null || activityLinkageData.Data == null)
		{
			return;
		}
		foreach (ActivityLinkagePageData activityLinkagePageData in activityLinkageData.Data)
		{
			ActivityLinkageTabData activityLinkageTabData;
			if (!this.TabDataMap.TryGetValue(activityLinkagePageData.PageActivityId, out activityLinkageTabData))
			{
				activityLinkageTabData = new ActivityLinkageTabData();
			}
			activityLinkageTabData.TabId = activityLinkagePageData.PageActivityId;
			activityLinkageTabData.StartTimeStamp = activityLinkagePageData.StartTime;
			activityLinkageTabData.EndTimeStamp = activityLinkagePageData.EndTime;
			activityLinkageTabData.IsReceive = activityLinkagePageData.Receive;
			activityLinkageTabData.IsInShowTimeChange();
			this.TabDataMap[activityLinkagePageData.PageActivityId] = activityLinkageTabData;
		}
	}

	// Token: 0x06004340 RID: 17216 RVA: 0x0017455C File Offset: 0x0017275C
	public void ReceiveReward(int tabId)
	{
		ActivityLinkageTabData activityLinkageTabData;
		if (!this.TabDataMap.TryGetValue(tabId, out activityLinkageTabData))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "活动联合页领取奖励，页签数据错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tabId", tabId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		activityLinkageTabData.IsReceive = true;
		this.TabDataMap[tabId] = activityLinkageTabData;
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06004341 RID: 17217 RVA: 0x001745D3 File Offset: 0x001727D3
	public void ReadRedDot()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06004342 RID: 17218 RVA: 0x00174600 File Offset: 0x00172800
	public override bool GetExDataRedPointShowState()
	{
		if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 0)
		{
			return true;
		}
		List<ActivityLinkageTabData> list = new List<ActivityLinkageTabData>();
		foreach (ActivityLinkageTabData activityLinkageTabData in this.TabDataMap.Values)
		{
			if (activityLinkageTabData.IsInShowTime)
			{
				list.Add(activityLinkageTabData);
			}
		}
		using (List<ActivityLinkageTabData>.Enumerator enumerator2 = list.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				if (!enumerator2.Current.IsReceive)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06004343 RID: 17219 RVA: 0x001746C4 File Offset: 0x001728C4
	public bool IsReceiveReward(int tabId)
	{
		ActivityLinkageTabData activityLinkageTabData;
		if (!this.TabDataMap.TryGetValue(tabId, out activityLinkageTabData))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "活动联动页页签id未找到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tabId", tabId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return activityLinkageTabData.IsReceive;
	}

	// Token: 0x06004344 RID: 17220 RVA: 0x00174718 File Offset: 0x00172918
	public bool IsNeedShowTabsChange()
	{
		bool result = false;
		using (Dictionary<int, ActivityLinkageTabData>.ValueCollection.Enumerator enumerator = this.TabDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsInShowTimeChange())
				{
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x06004345 RID: 17221 RVA: 0x00174774 File Offset: 0x00172974
	public List<ActivityLinkageTabData> GetTabInfoList()
	{
		this.IsNeedShowTabsChange();
		List<ActivityLinkageTabData> list = new List<ActivityLinkageTabData>();
		foreach (ActivityLinkageTabData activityLinkageTabData in this.TabDataMap.Values)
		{
			if (activityLinkageTabData.IsInShowTime)
			{
				list.Add(activityLinkageTabData);
			}
		}
		return NoLinq.OrderByDescendingThenByDescendingToList<ActivityLinkageTabData, int, int>(list, (ActivityLinkageTabData tab) => ConfigActivityLinkageById.GetConfig(tab.TabId, true).Value.Rank, (ActivityLinkageTabData tab) => tab.TabId);
	}

	// Token: 0x04003478 RID: 13432
	private const int ACTIVITYLINKAGE_RED_DOT_CACHE_KEY = 100;
}
