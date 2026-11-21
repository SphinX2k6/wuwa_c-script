using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A4C RID: 19020
	[NullableContext(2)]
	[Nullable(0)]
	public class FlagChallengeRoleCategoryItemData
	{
		// Token: 0x04019463 RID: 103523
		public EFlagChallengeRoleCategoryType CategoryType;

		// Token: 0x04019464 RID: 103524
		[Nullable(1)]
		public string TitleKey = "";

		// Token: 0x04019465 RID: 103525
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RoleDataBase> RoleList;

		// Token: 0x04019466 RID: 103526
		public Func<int, EToggleState, bool> CanSelectRole;

		// Token: 0x04019467 RID: 103527
		public Action<int, EToggleState> OnSelectRole;
	}
}
