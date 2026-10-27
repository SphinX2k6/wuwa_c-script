using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001470 RID: 5232
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressAreaSubView : ActivityRegressMainSubViewBase
{
	// Token: 0x06009410 RID: 37904 RVA: 0x001FE965 File Offset: 0x001FCB65
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = ActivityRegressMainViewComponentsInfo.Value;
	}

	// Token: 0x06009411 RID: 37905 RVA: 0x001FE974 File Offset: 0x001FCB74
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressAreaSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressAreaSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009412 RID: 37906 RVA: 0x001FE9B8 File Offset: 0x001FCBB8
	protected override void OnStart()
	{
		base.OnStart();
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(0);
		UUIItem item = base.GetItem(5);
		this.ActivityRegressTabGroupPanel = new ActivityRegressTabGroupPanel(horizontalLayout, item, new Action<int>(this.TabCallBack));
		this.ActivityRegressTabGroupPanel.Init();
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x06009413 RID: 37907 RVA: 0x001FEA0C File Offset: 0x001FCC0C
	protected override void OnBeforeDestroy()
	{
		this.ActivityRegressTabGroupPanel.Destroy();
		this.ActivityRegressTabGroupPanel = null;
	}

	// Token: 0x06009414 RID: 37908 RVA: 0x001FEA20 File Offset: 0x001FCC20
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

	// Token: 0x06009415 RID: 37909 RVA: 0x001FEAE0 File Offset: 0x001FCCE0
	private void TabCallBack(int index)
	{
		RegressBase? config = this.TabCommonDataList[index].Config;
		this.ActivityRegressAreaActivityInfoPanel.RefreshByData(config.Value);
		this.SequencePlayer.PlaySequence("Start", false, null);
	}

	// Token: 0x040041AE RID: 16814
	private ActivityRegressTabGroupPanel ActivityRegressTabGroupPanel;

	// Token: 0x040041AF RID: 16815
	private ActivityRegressAreaActivityInfoPanel ActivityRegressAreaActivityInfoPanel;

	// Token: 0x040041B0 RID: 16816
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRegressTabSwitchItemCommonData> TabCommonDataList;
}
