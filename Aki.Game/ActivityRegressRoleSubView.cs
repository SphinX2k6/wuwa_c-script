using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200094D RID: 2381
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressRoleSubView : ActivityRegressMainSubViewBase
{
	// Token: 0x060068FC RID: 26876 RVA: 0x0020C938 File Offset: 0x0020AB38
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = ActivityRegressMainViewComponentsInfo.Value;
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnPnlBtnClick))
		};
	}

	// Token: 0x060068FD RID: 26877 RVA: 0x0020C968 File Offset: 0x0020AB68
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressRoleSubView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressRoleSubView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060068FE RID: 26878 RVA: 0x0020C9AC File Offset: 0x0020ABAC
	protected override void OnStart()
	{
		base.OnStart();
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(0);
		UUIItem item = base.GetItem(5);
		this.ActivityRecallTabGroupPanel = new ActivityRegressTabGroupPanel(horizontalLayout, item, new Action<int>(this.TabCallBack));
		this.ActivityRecallTabGroupPanel.Init();
		base.GetItem(3).SetUIActive(true);
	}

	// Token: 0x060068FF RID: 26879 RVA: 0x0020CA00 File Offset: 0x0020AC00
	protected override void OnBeforeDestroy()
	{
		this.ActivityRecallTabGroupPanel.Destroy();
		this.ActivityRecallTabGroupPanel = null;
	}

	// Token: 0x06006900 RID: 26880 RVA: 0x0020CA14 File Offset: 0x0020AC14
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

	// Token: 0x06006901 RID: 26881 RVA: 0x0020CB08 File Offset: 0x0020AD08
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

	// Token: 0x06006902 RID: 26882 RVA: 0x0020CBC4 File Offset: 0x0020ADC4
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

	// Token: 0x06006903 RID: 26883 RVA: 0x0020CC04 File Offset: 0x0020AE04
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

	// Token: 0x06006904 RID: 26884 RVA: 0x0020CC6C File Offset: 0x0020AE6C
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

	// Token: 0x040042A5 RID: 17061
	private ActivityRoleDescribeComponent RoleDescPanel;

	// Token: 0x040042A6 RID: 17062
	private ActivityRegressTabGroupPanel ActivityRecallTabGroupPanel;

	// Token: 0x040042A7 RID: 17063
	private ActivityRegressRoleActivityInfoPanel ActivityRecallRoleActivityInfoPanel;

	// Token: 0x040042A8 RID: 17064
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRegressTabSwitchItemCommonData> TabCommonDataList;

	// Token: 0x040042A9 RID: 17065
	private EActivityRegressEntranceType? EntryType;

	// Token: 0x040042AA RID: 17066
	private RegressBase? Config;

	// Token: 0x040042AB RID: 17067
	private GachaPoolItem GachaPoolItem;

	// Token: 0x040042AC RID: 17068
	private ERecallRolePoolItemType? RolePoolItemType;

	// Token: 0x040042AD RID: 17069
	private float PoolItemAnchorOffsetX;
}
