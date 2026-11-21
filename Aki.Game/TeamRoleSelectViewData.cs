using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C7F RID: 7295
[NullableContext(2)]
[Nullable(0)]
public class TeamRoleSelectViewData : UiPopViewData
{
	// Token: 0x06012186 RID: 74118 RVA: 0x0055314C File Offset: 0x0055134C
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

	// Token: 0x06012187 RID: 74119 RVA: 0x005531AA File Offset: 0x005513AA
	[NullableContext(1)]
	public void SetHideFinishCallBack(Action hideFinishFunction)
	{
		this.OnHideFinishCallBack = hideFinishFunction;
	}

	// Token: 0x06012188 RID: 74120 RVA: 0x005531B3 File Offset: 0x005513B3
	public void SetGetConfirmButtonTextFunction([Nullable(new byte[]
	{
		1,
		2
	})] Func<int, string> getConfirmButtonTextCallBack)
	{
		this.GetConfirmButtonTextCallBack = getConfirmButtonTextCallBack;
	}

	// Token: 0x06012189 RID: 74121 RVA: 0x005531BC File Offset: 0x005513BC
	[NullableContext(1)]
	public void SetGetConfirmButtonEnableFunction(Func<int, bool> getConfirmButtonEnableCallBack)
	{
		this.GetConfirmButtonEnableCallBack = getConfirmButtonEnableCallBack;
	}

	// Token: 0x0601218A RID: 74122 RVA: 0x005531C5 File Offset: 0x005513C5
	[NullableContext(1)]
	public void SetOtherTeamSlotData(List<BattleRoleSlotData> dataList)
	{
		this.BattleRoleSlotDataList = dataList;
	}

	// Token: 0x0601218B RID: 74123 RVA: 0x005531CE File Offset: 0x005513CE
	[NullableContext(1)]
	public void SetConfirmCheckFunction(Func<int, bool> getConfirmCheckCallBack)
	{
		this.CanConfirmFunc = getConfirmCheckCallBack;
	}

	// Token: 0x04009DCE RID: 40398
	public EFilterSortGroupId? UseWay;

	// Token: 0x04009DCF RID: 40399
	public int CurrentRoleId;

	// Token: 0x04009DD0 RID: 40400
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<RoleDataBase> RoleList;

	// Token: 0x04009DD1 RID: 40401
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<BattleRoleSlotData> BattleRoleSlotDataList;

	// Token: 0x04009DD2 RID: 40402
	public int? Position = new int?(0);

	// Token: 0x04009DD3 RID: 40403
	public ETeamRoleUseFunction ForFunction;

	// Token: 0x04009DD4 RID: 40404
	public int[] FormationRoleList;

	// Token: 0x04009DD5 RID: 40405
	public bool CanUseSpecialTrialRole;

	// Token: 0x04009DD6 RID: 40406
	public Action<int> ConfirmCallBack;

	// Token: 0x04009DD7 RID: 40407
	public Action OnHideFinishCallBack;

	// Token: 0x04009DD8 RID: 40408
	public Action BackCallBack;

	// Token: 0x04009DD9 RID: 40409
	public Func<int, string> GetConfirmButtonTextCallBack;

	// Token: 0x04009DDA RID: 40410
	public Func<int, bool> GetConfirmButtonEnableCallBack;

	// Token: 0x04009DDB RID: 40411
	public Func<int, bool> IsNeedRevive;

	// Token: 0x04009DDC RID: 40412
	public Func<int, bool> CanConfirmFunc;

	// Token: 0x04009DDD RID: 40413
	public Func<int, bool> CanJoinTeam;

	// Token: 0x04009DDE RID: 40414
	public Action<int> OnRoleSelect;

	// Token: 0x04009DDF RID: 40415
	public Action<UUIItem> OnModelLoadingAnchorChanged;

	// Token: 0x04009DE0 RID: 40416
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Func<int, List<TeamRoleSkillData>> GetCustomSkillShowData;

	// Token: 0x04009DE1 RID: 40417
	public Action<int> DetailCallback;

	// Token: 0x04009DE2 RID: 40418
	public Action OnDetailOpen;

	// Token: 0x04009DE3 RID: 40419
	public Action OnDetailClose;

	// Token: 0x04009DE4 RID: 40420
	public Func<int, bool> ShowLockPanel;

	// Token: 0x04009DE5 RID: 40421
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int, string> GetLockTextCallBack;

	// Token: 0x04009DE6 RID: 40422
	public Func<int, bool> GetDetailButtonVisible;

	// Token: 0x04009DE7 RID: 40423
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<TeamRoleGridBase> OverrideGridProxyCreate;
}
