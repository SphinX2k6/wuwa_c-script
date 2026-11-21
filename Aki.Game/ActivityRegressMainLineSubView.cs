using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200093E RID: 2366
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressMainLineSubView : ActivityRegressMainSubViewBase
{
	// Token: 0x06006884 RID: 26756 RVA: 0x0020AD04 File Offset: 0x00208F04
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = ActivityRegressMainViewComponentsInfo.Value;
	}

	// Token: 0x06006885 RID: 26757 RVA: 0x0020AD14 File Offset: 0x00208F14
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressMainLineSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressMainLineSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006886 RID: 26758 RVA: 0x0020AD58 File Offset: 0x00208F58
	protected override void OnStart()
	{
		base.OnStart();
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(0);
		UUIItem item = base.GetItem(5);
		this.ActivityRecallTabGroupPanel = new ActivityRegressTabGroupPanel(horizontalLayout, item, new Action<int>(this.TabCallBack));
		this.ActivityRecallTabGroupPanel.Init();
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x06006887 RID: 26759 RVA: 0x0020ADAC File Offset: 0x00208FAC
	protected override void OnBeforeDestroy()
	{
		this.ActivityRecallTabGroupPanel.Destroy();
		this.ActivityRecallTabGroupPanel = null;
	}

	// Token: 0x06006888 RID: 26760 RVA: 0x0020ADC0 File Offset: 0x00208FC0
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

	// Token: 0x06006889 RID: 26761 RVA: 0x0020AE80 File Offset: 0x00209080
	private void TabCallBack(int index)
	{
		RegressBase? config = this.TabCommonDataList[index].Config;
		this.ActivityRecallMainLineActivityInfoPanel.RefreshByData(config.Value);
		this.SequencePlayer.PlaySequence("Start", false, null);
	}

	// Token: 0x0400428A RID: 17034
	private ActivityRegressTabGroupPanel ActivityRecallTabGroupPanel;

	// Token: 0x0400428B RID: 17035
	private ActivityRegressMainLineActivityInfoPanel ActivityRecallMainLineActivityInfoPanel;

	// Token: 0x0400428C RID: 17036
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRegressTabSwitchItemCommonData> TabCommonDataList;
}
