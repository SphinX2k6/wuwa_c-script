using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001C6F RID: 7279
[NullableContext(1)]
[Nullable(0)]
public class MultiTeamRoleGridContentData
{
	// Token: 0x04009D68 RID: 40296
	public bool ShowGridAnimation;

	// Token: 0x04009D69 RID: 40297
	[Nullable(2)]
	public MultiTeamRoleData Data;

	// Token: 0x04009D6A RID: 40298
	public int[] CurrentSelectedRoleList = new int[0];

	// Token: 0x04009D6B RID: 40299
	public bool IsSingleSelect;

	// Token: 0x04009D6C RID: 40300
	public Dictionary<int, int> CurrentSelectTagMap = new Dictionary<int, int>();

	// Token: 0x04009D6D RID: 40301
	public Action<MediumItemGridExtendCallback> OnToggleCallBack = delegate(MediumItemGridExtendCallback _)
	{
	};

	// Token: 0x04009D6E RID: 40302
	public Func<object, bool, EToggleState, bool> CanExecuteChangeCallBack = (object data, bool isForceSelected, EToggleState state) => true;
}
