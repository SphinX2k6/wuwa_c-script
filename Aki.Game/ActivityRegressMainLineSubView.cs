using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200148A RID: 5258
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressMainLineSubView : ActivityRegressMainSubViewBase
{
	// Token: 0x060094EF RID: 38127 RVA: 0x00201D9C File Offset: 0x001FFF9C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = ActivityRegressMainViewComponentsInfo.Value;
	}

	// Token: 0x060094F0 RID: 38128 RVA: 0x00201DAC File Offset: 0x001FFFAC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressMainLineSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressMainLineSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060094F1 RID: 38129 RVA: 0x00201DF0 File Offset: 0x001FFFF0
	protected override void OnStart()
	{
		base.OnStart();
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(0);
		UUIItem item = base.GetItem(5);
		this.ActivityRecallTabGroupPanel = new ActivityRegressTabGroupPanel(horizontalLayout, item, new Action<int>(this.TabCallBack));
		this.ActivityRecallTabGroupPanel.Init();
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x060094F2 RID: 38130 RVA: 0x00201E44 File Offset: 0x00200044
	protected override void OnBeforeDestroy()
	{
		this.ActivityRecallTabGroupPanel.Destroy();
		this.ActivityRecallTabGroupPanel = null;
	}

	// Token: 0x060094F3 RID: 38131 RVA: 0x00201E58 File Offset: 0x00200058
	protected override void OnUpdate(int subTabIndex)
	{
		IReadOnlyList<RegressBase> lastestRegressBaseConfigList = ActivityRegressModel.Instance.GetLastestRegressBaseConfigList(EActivityRegressEntranceType.NewMainLine);
		this.TabCommonDataList = new List<ActivityRegressTabSwitchItemCommonData>();
		if (lastestRegressBaseConfigList != null)
		{
			foreach (RegressBase value in lastestRegressBaseConfigList)
			{
				ActivityRegressTabSwitchItemCommonData item = new ActivityRegressTabSwitchItemCommonData
				{
					RecallEntryType = new EActivityRegressEntranceType?(EActivityRegressEntranceType.NewMainLine),
					Config = new RegressBase?(value),
					Title = value.Title
				};
				this.TabCommonDataList.Add(item);
			}
		}
		base.GetItem(7).SetUIActive(this.TabCommonDataList.Count > 1);
		this.ActivityRecallTabGroupPanel.RefreshByData(this.TabCommonDataList, subTabIndex);
	}

	// Token: 0x060094F4 RID: 38132 RVA: 0x00201F18 File Offset: 0x00200118
	private void TabCallBack(int index)
	{
		RegressBase? config = this.TabCommonDataList[index].Config;
		this.ActivityRecallMainLineActivityInfoPanel.RefreshByData(config.Value);
		this.SequencePlayer.PlaySequence("Start", false, null);
	}

	// Token: 0x040041F2 RID: 16882
	private ActivityRegressTabGroupPanel ActivityRecallTabGroupPanel;

	// Token: 0x040041F3 RID: 16883
	private ActivityRegressMainLineActivityInfoPanel ActivityRecallMainLineActivityInfoPanel;

	// Token: 0x040041F4 RID: 16884
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRegressTabSwitchItemCommonData> TabCommonDataList;
}
