using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A70 RID: 23152
	[NullableContext(2)]
	[Nullable(0)]
	public class FlagChallengeRoleCategoryItemData
	{
		// Token: 0x0401E9BC RID: 125372
		public EFlagChallengeRoleCategoryType CategoryType;

		// Token: 0x0401E9BD RID: 125373
		[Nullable(1)]
		public string TitleKey = "";

		// Token: 0x0401E9BE RID: 125374
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RoleDataBase> RoleList;

		// Token: 0x0401E9BF RID: 125375
		public Func<int, EToggleState, bool> CanSelectRole;

		// Token: 0x0401E9C0 RID: 125376
		public Action<int, EToggleState> OnSelectRole;
	}
}
