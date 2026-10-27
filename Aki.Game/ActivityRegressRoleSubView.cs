using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001499 RID: 5273
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressRoleSubView : ActivityRegressMainSubViewBase
{
	// Token: 0x06009567 RID: 38247 RVA: 0x002039D0 File Offset: 0x00201BD0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = ActivityRegressMainViewComponentsInfo.Value;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnPnlBtnClick))
		};
	}

	// Token: 0x06009568 RID: 38248 RVA: 0x00203A00 File Offset: 0x00201C00
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressRoleSubView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressRoleSubView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009569 RID: 38249 RVA: 0x00203A44 File Offset: 0x00201C44
	protected override void OnStart()
	{
		base.OnStart();
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(0);
		UUIItem item = base.GetItem(5);
		this.ActivityRecallTabGroupPanel = new ActivityRegressTabGroupPanel(horizontalLayout, item, new Action<int>(this.TabCallBack));
		this.ActivityRecallTabGroupPanel.Init();
		base.GetItem(3).SetUIActive(true);
	}

	// Token: 0x0600956A RID: 38250 RVA: 0x00203A98 File Offset: 0x00201C98
	protected override void OnBeforeDestroy()
	{
		this.ActivityRecallTabGroupPanel.Destroy();
		this.ActivityRecallTabGroupPanel = null;
	}

	// Token: 0x0600956B RID: 38251 RVA: 0x00203AAC File Offset: 0x00201CAC
	protected override void OnUpdate(int subTabIndex)
	{
		List<RegressBase?> sortedOpenRegressBaseConfigList = ActivityRegressConfig.Instance.GetSortedOpenRegressBaseConfigList();
		this.TabCommonDataList = new List<ActivityRegressTabSwitchItemCommonData>();
		foreach (RegressBase? config in sortedOpenRegressBaseConfigList)
		{
			RoleInfo? roleConfigByGachaId = ActivityRegressModel.Instance.GetRoleConfigByGachaId(config.Value.GachaId);
			ActivityRegressTabSwitchItemCommonData item = new ActivityRegressTabSwitchItemCommonData
			{
				RecallEntryType = this.EntryType,
				Config = config,
				Title = (((roleConfigByGachaId != null) ? roleConfigByGachaId.GetValueOrDefault().Name : null) ?? "")
			};
			this.TabCommonDataList.Add(item);
		}
		base.GetItem(7).SetUIActive(this.TabCommonDataList.Count > 1);
		this.ActivityRecallTabGroupPanel.RefreshByData(this.TabCommonDataList, subTabIndex);
	}

	// Token: 0x0600956C RID: 38252 RVA: 0x00203BA0 File Offset: 0x00201DA0
	private void TabCallBack(int index)
	{
		ActivityRegressTabSwitchItemCommonData activityRegressTabSwitchItemCommonData = this.TabCommonDataList[index];
		RegressBase value = activityRegressTabSwitchItemCommonData.Config.Value;
		this.ActivityRecallRoleActivityInfoPanel.RefreshData(value);
		ProtoGachaInfo gachaInfo = GachaModel.Instance.GetGachaInfo(value.GachaId);
		if (gachaInfo == null)
		{
			return;
		}
		int usePoolId = gachaInfo.UsePoolId;
		ProtoGachaPoolInfo protoGachaPoolInfo = (usePoolId > 0) ? gachaInfo.GetPoolInfo(usePoolId) : gachaInfo.GetFirstValidPool();
		if (protoGachaPoolInfo == null)
		{
			return;
		}
		this.UpdateGachaPoolItem(gachaInfo, protoGachaPoolInfo);
		this.Config = activityRegressTabSwitchItemCommonData.Config;
		int gachaRoleId = ActivityRegressModel.Instance.GetGachaRoleId(value.GachaId);
		this.RoleDescPanel.Update(gachaRoleId);
		this.SequencePlayer.PlaySequence("Start", false, null);
	}

	// Token: 0x0600956D RID: 38253 RVA: 0x00203C5C File Offset: 0x00201E5C
	public override void OnParentShow()
	{
		base.OnParentShow();
		SpineRoleGachaPoolItem spineRoleGachaPoolItem = this.GachaPoolItem as SpineRoleGachaPoolItem;
		if (spineRoleGachaPoolItem != null)
		{
			spineRoleGachaPoolItem.PlayStartSeq();
			return;
		}
		UpRoleGachaPoolItem upRoleGachaPoolItem = this.GachaPoolItem as UpRoleGachaPoolItem;
		if (upRoleGachaPoolItem != null)
		{
			upRoleGachaPoolItem.PlayStartSeq();
		}
	}

	// Token: 0x0600956E RID: 38254 RVA: 0x00203C9C File Offset: 0x00201E9C
	private unsafe void OnPnlBtnClick()
	{
		int gachaTrialRoleId = ActivityRegressModel.Instance.GetGachaTrialRoleId(this.Config.Value.GachaId);
		RoleController instance = RoleController.Instance;
		ERoleAgentType agentType = ERoleAgentType.Preview;
		int selectRoleId = 0;
		int num = 1;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount<int>(list, num);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int index = 0;
		*span[index] = gachaTrialRoleId;
		instance.OpenRoleMainView(agentType, selectRoleId, list, null, null);
	}

	// Token: 0x0600956F RID: 38255 RVA: 0x00203D04 File Offset: 0x00201F04
	[NullableContext(1)]
	private UniTask UpdateGachaPoolItem(ProtoGachaInfo gachaInfo, ProtoGachaPoolInfo poolInfo)
	{
		ActivityRegressRoleSubView.<UpdateGachaPoolItem>d__17 <UpdateGachaPoolItem>d__;
		<UpdateGachaPoolItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateGachaPoolItem>d__.<>4__this = this;
		<UpdateGachaPoolItem>d__.gachaInfo = gachaInfo;
		<UpdateGachaPoolItem>d__.poolInfo = poolInfo;
		<UpdateGachaPoolItem>d__.<>1__state = -1;
		<UpdateGachaPoolItem>d__.<>t__builder.Start<ActivityRegressRoleSubView.<UpdateGachaPoolItem>d__17>(ref <UpdateGachaPoolItem>d__);
		return <UpdateGachaPoolItem>d__.<>t__builder.Task;
	}

	// Token: 0x0400420D RID: 16909
	private ActivityRoleDescribeComponent RoleDescPanel;

	// Token: 0x0400420E RID: 16910
	private ActivityRegressTabGroupPanel ActivityRecallTabGroupPanel;

	// Token: 0x0400420F RID: 16911
	private ActivityRegressRoleActivityInfoPanel ActivityRecallRoleActivityInfoPanel;

	// Token: 0x04004210 RID: 16912
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRegressTabSwitchItemCommonData> TabCommonDataList;

	// Token: 0x04004211 RID: 16913
	private EActivityRegressEntranceType? EntryType;

	// Token: 0x04004212 RID: 16914
	private RegressBase? Config;

	// Token: 0x04004213 RID: 16915
	private GachaPoolItem GachaPoolItem;

	// Token: 0x04004214 RID: 16916
	private ERecallRolePoolItemType? RolePoolItemType;

	// Token: 0x04004215 RID: 16917
	private float PoolItemAnchorOffsetX;
}
