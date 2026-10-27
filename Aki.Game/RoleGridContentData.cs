using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02002786 RID: 10118
[NullableContext(1)]
[Nullable(0)]
internal class RoleGridContentData
{
	// Token: 0x04009C17 RID: 39959
	[Nullable(2)]
	public MultiTeamRoleGridData Data;

	// Token: 0x04009C18 RID: 39960
	public int[] CurrentSelectedRoleList = new int[0];

	// Token: 0x04009C19 RID: 39961
	public int CurrentTagBranchId = -1;

	// Token: 0x04009C1A RID: 39962
	public Action<MediumItemGridExtendCallback> OnToggleCallBack = delegate(MediumItemGridExtendCallback _)
	{
	};

	// Token: 0x04009C1B RID: 39963
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public Func<object, bool, EToggleState, bool> CanExecuteChangeCallBack = (object data, bool isForceSelected, EToggleState state) => true;
}
