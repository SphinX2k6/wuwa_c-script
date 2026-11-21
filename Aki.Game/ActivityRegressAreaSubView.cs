using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000924 RID: 2340
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressAreaSubView : ActivityRegressMainSubViewBase
{
	// Token: 0x060067A5 RID: 26533 RVA: 0x002078C9 File Offset: 0x00205AC9
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = ActivityRegressMainViewComponentsInfo.Value;
	}

	// Token: 0x060067A6 RID: 26534 RVA: 0x002078D8 File Offset: 0x00205AD8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressAreaSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressAreaSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060067A7 RID: 26535 RVA: 0x0020791C File Offset: 0x00205B1C
	protected override void OnStart()
	{
		base.OnStart();
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(0);
		UUIItem item = base.GetItem(5);
		this.ActivityRegressTabGroupPanel = new ActivityRegressTabGroupPanel(horizontalLayout, item, new Action<int>(this.TabCallBack));
		this.ActivityRegressTabGroupPanel.Init();
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x060067A8 RID: 26536 RVA: 0x00207970 File Offset: 0x00205B70
	protected override void OnBeforeDestroy()
	{
		this.ActivityRegressTabGroupPanel.Destroy();
		this.ActivityRegressTabGroupPanel = null;
	}

	// Token: 0x060067A9 RID: 26537 RVA: 0x00207984 File Offset: 0x00205B84
	protected override void OnUpdate(int subTabIndex)
	{
		IReadOnlyList<RegressBase> lastestRegressBaseConfigList = ActivityRegressModel.Instance.GetLastestRegressBaseConfigList(EActivityRegressEntranceType.NewArea);
		this.TabCommonDataList = new List<ActivityRegressTabSwitchItemCommonData>();
		if (lastestRegressBaseConfigList != null)
		{
			foreach (RegressBase value in lastestRegressBaseConfigList)
			{
				ActivityRegressTabSwitchItemCommonData item = new ActivityRegressTabSwitchItemCommonData
				{
					RecallEntryType = new EActivityRegressEntranceType?(EActivityRegressEntranceType.NewArea),
					Config = new RegressBase?(value),
					Title = value.Title
				};
				this.TabCommonDataList.Add(item);
			}
		}
		base.GetItem(7).SetUIActive(this.TabCommonDataList.Count > 1);
		this.ActivityRegressTabGroupPanel.RefreshByData(this.TabCommonDataList, subTabIndex);
	}

	// Token: 0x060067AA RID: 26538 RVA: 0x00207A44 File Offset: 0x00205C44
	private void TabCallBack(int index)
	{
		RegressBase? config = this.TabCommonDataList[index].Config;
		this.ActivityRegressAreaActivityInfoPanel.RefreshByData(config.Value);
		this.SequencePlayer.PlaySequence("Start", false, null);
	}

	// Token: 0x04004246 RID: 16966
	private ActivityRegressTabGroupPanel ActivityRegressTabGroupPanel;

	// Token: 0x04004247 RID: 16967
	private ActivityRegressAreaActivityInfoPanel ActivityRegressAreaActivityInfoPanel;

	// Token: 0x04004248 RID: 16968
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRegressTabSwitchItemCommonData> TabCommonDataList;
}
