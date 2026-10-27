using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020010C0 RID: 4288
[NullableContext(1)]
[Nullable(0)]
public class ActivityLinkageData : ActivityBaseData
{
	// Token: 0x17000974 RID: 2420
	// (get) Token: 0x06006FA8 RID: 28584 RVA: 0x0016BB1A File Offset: 0x00169D1A
	public Dictionary<int, ActivityLinkageTabData> TabDataMap { get; } = new Dictionary<int, ActivityLinkageTabData>();

	// Token: 0x06006FA9 RID: 28585 RVA: 0x0016BB24 File Offset: 0x00169D24
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

	// Token: 0x06006FAA RID: 28586 RVA: 0x0016BBE4 File Offset: 0x00169DE4
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

	// Token: 0x06006FAB RID: 28587 RVA: 0x0016BC5B File Offset: 0x00169E5B
	public void ReadRedDot()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06006FAC RID: 28588 RVA: 0x0016BC88 File Offset: 0x00169E88
	public override bool GetExDataRedPointShowState()
	{
		if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 100, 0, 0) == 0)
		{
			return true;
		}
		using (List<ActivityLinkageTabData>.Enumerator enumerator = (from tabInfo in this.TabDataMap.Values
		where tabInfo.IsInShowTime
		select tabInfo).ToList<ActivityLinkageTabData>().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsReceive)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06006FAD RID: 28589 RVA: 0x0016BD28 File Offset: 0x00169F28
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

	// Token: 0x06006FAE RID: 28590 RVA: 0x0016BD7C File Offset: 0x00169F7C
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

	// Token: 0x06006FAF RID: 28591 RVA: 0x0016BDD8 File Offset: 0x00169FD8
	public List<ActivityLinkageTabData> GetTabInfoList()
	{
		this.IsNeedShowTabsChange();
		return (from tabData in (from tabInfo in this.TabDataMap.Values
		where tabInfo.IsInShowTime
		select tabInfo).ToList<ActivityLinkageTabData>()
		orderby ConfigActivityLinkageById.GetConfig(tabData.TabId, true).Value.Rank descending, tabData.TabId descending
		select tabData).ToList<ActivityLinkageTabData>();
	}

	// Token: 0x040033DF RID: 13279
	private const int ACTIVITYLINKAGE_RED_DOT_CACHE_KEY = 100;
}
