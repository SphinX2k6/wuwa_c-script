using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001C71 RID: 7281
[NullableContext(1)]
[Nullable(0)]
internal class RoleGridContentData
{
	// Token: 0x04009D70 RID: 40304
	[Nullable(2)]
	public MultiTeamRoleGridData Data;

	// Token: 0x04009D71 RID: 40305
	public int[] CurrentSelectedRoleList = new int[0];

	// Token: 0x04009D72 RID: 40306
	public bool IsSingleSelect;

	// Token: 0x04009D73 RID: 40307
	public int CurrentTagBranchId = -1;

	// Token: 0x04009D74 RID: 40308
	public Action<MediumItemGridExtendCallback> OnToggleCallBack = delegate(MediumItemGridExtendCallback _)
	{
	};

	// Token: 0x04009D75 RID: 40309
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public Func<object, bool, EToggleState, bool> CanExecuteChangeCallBack = (object data, bool isForceSelected, EToggleState state) => true;
}
