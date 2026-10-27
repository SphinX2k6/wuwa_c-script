using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02002784 RID: 10116
[NullableContext(1)]
[Nullable(0)]
public class MultiTeamRoleGridContentData
{
	// Token: 0x04009C10 RID: 39952
	public bool ShowGridAnimation;

	// Token: 0x04009C11 RID: 39953
	[Nullable(2)]
	public MultiTeamRoleData Data;

	// Token: 0x04009C12 RID: 39954
	public int[] CurrentSelectedRoleList = new int[0];

	// Token: 0x04009C13 RID: 39955
	public Dictionary<int, int> CurrentSelectTagMap = new Dictionary<int, int>();

	// Token: 0x04009C14 RID: 39956
	public Action<MediumItemGridExtendCallback> OnToggleCallBack = delegate(MediumItemGridExtendCallback _)
	{
	};

	// Token: 0x04009C15 RID: 39957
	public Func<object, bool, EToggleState, bool> CanExecuteChangeCallBack = (object data, bool isForceSelected, EToggleState state) => true;
}
