using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02001C78 RID: 7288
[NullableContext(2)]
[Nullable(0)]
public class QuickRoleSelectViewData
{
	// Token: 0x0601214C RID: 74060 RVA: 0x005516A9 File Offset: 0x0054F8A9
	[NullableContext(1)]
	public QuickRoleSelectViewData(EFilterSortGroupId useWay, int[] selectedRoleList, List<RoleDataBase> roleList)
	{
		this.UseWay = new EFilterSortGroupId?(useWay);
		this.SelectedRoleList = selectedRoleList;
		this.RoleList = roleList;
	}

	// Token: 0x04009DAE RID: 40366
	public EFilterSortGroupId? UseWay;

	// Token: 0x04009DAF RID: 40367
	public int[] SelectedRoleList;

	// Token: 0x04009DB0 RID: 40368
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<RoleDataBase> RoleList;

	// Token: 0x04009DB1 RID: 40369
	[Nullable(1)]
	public string YellowTipText = "";

	// Token: 0x04009DB2 RID: 40370
	public bool IsNeedChangeBtnState;

	// Token: 0x04009DB3 RID: 40371
	public bool CanUseSpecialTrialRole;

	// Token: 0x04009DB4 RID: 40372
	public bool ShowDetailButton = true;

	// Token: 0x04009DB5 RID: 40373
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int[], bool> CanConfirm;

	// Token: 0x04009DB6 RID: 40374
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int[]> OnConfirm;

	// Token: 0x04009DB7 RID: 40375
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<List<int>, UniTask> OnWaitLoadingConfirm;

	// Token: 0x04009DB8 RID: 40376
	public Action OnBack;

	// Token: 0x04009DB9 RID: 40377
	public Action OnHideFinish;

	// Token: 0x04009DBA RID: 40378
	public Action OnRoleSelectFull;

	// Token: 0x04009DBB RID: 40379
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<int, int[], bool> CanSelectRole;
}
