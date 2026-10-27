using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002794 RID: 10132
[NullableContext(2)]
[Nullable(0)]
public class TeamRoleSelectViewData : UiPopViewData
{
	// Token: 0x06014C9B RID: 85147 RVA: 0x00544050 File Offset: 0x00542250
	public TeamRoleSelectViewData(EFilterSortGroupId useWay, int currentRoleId, [Nullable(1)] List<RoleDataBase> roleList, Action<int> confirmFunction, Action backFunction, int? position = null, ETeamRoleUseFunction? forFunction = null)
	{
		this.UseWay = new EFilterSortGroupId?(useWay);
		this.CurrentRoleId = currentRoleId;
		this.RoleList = roleList;
		this.BackCallBack = backFunction;
		this.ConfirmCallBack = confirmFunction;
		this.Position = position;
		this.ForFunction = forFunction.GetValueOrDefault();
	}

	// Token: 0x06014C9C RID: 85148 RVA: 0x005440AE File Offset: 0x005422AE
	[NullableContext(1)]
	public void SetHideFinishCallBack(Action hideFinishFunction)
	{
		this.OnHideFinishCallBack = hideFinishFunction;
	}

	// Token: 0x06014C9D RID: 85149 RVA: 0x005440B7 File Offset: 0x005422B7
	public void SetGetConfirmButtonTextFunction([Nullable(new byte[]
	{
		1,
		2
	})] Func<int, string> getConfirmButtonTextCallBack)
	{
		this.GetConfirmButtonTextCallBack = getConfirmButtonTextCallBack;
	}

	// Token: 0x06014C9E RID: 85150 RVA: 0x005440C0 File Offset: 0x005422C0
	[NullableContext(1)]
	public void SetGetConfirmButtonEnableFunction(Func<int, bool> getConfirmButtonEnableCallBack)
	{
		this.GetConfirmButtonEnableCallBack = getConfirmButtonEnableCallBack;
	}

	// Token: 0x06014C9F RID: 85151 RVA: 0x005440C9 File Offset: 0x005422C9
	[NullableContext(1)]
	public void SetOtherTeamSlotData(List<BattleRoleSlotData> dataList)
	{
		this.BattleRoleSlotDataList = dataList;
	}

	// Token: 0x06014CA0 RID: 85152 RVA: 0x005440D2 File Offset: 0x005422D2
	[NullableContext(1)]
	public void SetConfirmCheckFunction(Func<int, bool> getConfirmCheckCallBack)
	{
		this.CanConfirmFunc = getConfirmCheckCallBack;
	}

	// Token: 0x04009C6A RID: 40042
	public EFilterSortGroupId? UseWay;

	// Token: 0x04009C6B RID: 40043
	public int CurrentRoleId;

	// Token: 0x04009C6C RID: 40044
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<RoleDataBase> RoleList;

	// Token: 0x04009C6D RID: 40045
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<BattleRoleSlotData> BattleRoleSlotDataList;

	// Token: 0x04009C6E RID: 40046
	public int? Position = new int?(0);

	// Token: 0x04009C6F RID: 40047
	public ETeamRoleUseFunction ForFunction;

	// Token: 0x04009C70 RID: 40048
	public int[] FormationRoleList;

	// Token: 0x04009C71 RID: 40049
	public bool CanUseSpecialTrialRole;

	// Token: 0x04009C72 RID: 40050
	public Action<int> ConfirmCallBack;

	// Token: 0x04009C73 RID: 40051
	public Action OnHideFinishCallBack;

	// Token: 0x04009C74 RID: 40052
	public Action BackCallBack;

	// Token: 0x04009C75 RID: 40053
	public Func<int, string> GetConfirmButtonTextCallBack;

	// Token: 0x04009C76 RID: 40054
	public Func<int, bool> GetConfirmButtonEnableCallBack;

	// Token: 0x04009C77 RID: 40055
	public Func<int, bool> IsNeedRevive;

	// Token: 0x04009C78 RID: 40056
	public Func<int, bool> CanConfirmFunc;

	// Token: 0x04009C79 RID: 40057
	public Func<int, bool> CanJoinTeam;

	// Token: 0x04009C7A RID: 40058
	public Action<int> OnRoleSelect;

	// Token: 0x04009C7B RID: 40059
	public Action<UUIItem> OnModelLoadingAnchorChanged;

	// Token: 0x04009C7C RID: 40060
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Func<int, List<TeamRoleSkillData>> GetCustomSkillShowData;

	// Token: 0x04009C7D RID: 40061
	public Action<int> DetailCallback;

	// Token: 0x04009C7E RID: 40062
	public Action OnDetailOpen;

	// Token: 0x04009C7F RID: 40063
	public Action OnDetailClose;

	// Token: 0x04009C80 RID: 40064
	public Func<int, bool> ShowLockPanel;

	// Token: 0x04009C81 RID: 40065
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int, string> GetLockTextCallBack;

	// Token: 0x04009C82 RID: 40066
	public Func<int, bool> GetDetailButtonVisible;

	// Token: 0x04009C83 RID: 40067
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<TeamRoleGridBase> OverrideGridProxyCreate;
}
