using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x0200278D RID: 10125
[NullableContext(2)]
[Nullable(0)]
public class QuickRoleSelectViewData
{
	// Token: 0x06014C61 RID: 85089 RVA: 0x005425D5 File Offset: 0x005407D5
	[NullableContext(1)]
	public QuickRoleSelectViewData(EFilterSortGroupId useWay, int[] selectedRoleList, List<RoleDataBase> roleList)
	{
		this.UseWay = new EFilterSortGroupId?(useWay);
		this.SelectedRoleList = selectedRoleList;
		this.RoleList = roleList;
	}

	// Token: 0x04009C4A RID: 40010
	public EFilterSortGroupId? UseWay;

	// Token: 0x04009C4B RID: 40011
	public int[] SelectedRoleList;

	// Token: 0x04009C4C RID: 40012
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<RoleDataBase> RoleList;

	// Token: 0x04009C4D RID: 40013
	[Nullable(1)]
	public string YellowTipText = "";

	// Token: 0x04009C4E RID: 40014
	public bool IsNeedChangeBtnState;

	// Token: 0x04009C4F RID: 40015
	public bool CanUseSpecialTrialRole;

	// Token: 0x04009C50 RID: 40016
	public bool ShowDetailButton = true;

	// Token: 0x04009C51 RID: 40017
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int[], bool> CanConfirm;

	// Token: 0x04009C52 RID: 40018
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int[]> OnConfirm;

	// Token: 0x04009C53 RID: 40019
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<List<int>, UniTask> OnWaitLoadingConfirm;

	// Token: 0x04009C54 RID: 40020
	public Action OnBack;

	// Token: 0x04009C55 RID: 40021
	public Action OnHideFinish;

	// Token: 0x04009C56 RID: 40022
	public Action OnRoleSelectFull;

	// Token: 0x04009C57 RID: 40023
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int, int[], bool> CanSelectRole;
}
