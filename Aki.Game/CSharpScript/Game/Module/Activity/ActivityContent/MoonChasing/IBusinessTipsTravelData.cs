using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x020053F7 RID: 21495
	[NullableContext(1)]
	public interface IBusinessTipsTravelData
	{
		// Token: 0x17006803 RID: 26627
		// (get) Token: 0x060356E1 RID: 218849
		// (set) Token: 0x060356E2 RID: 218850
		List<int> RoleList { get; set; }

		// Token: 0x17006804 RID: 26628
		// (get) Token: 0x060356E3 RID: 218851
		// (set) Token: 0x060356E4 RID: 218852
		List<int> LastLevelList { get; set; }

		// Token: 0x17006805 RID: 26629
		// (get) Token: 0x060356E5 RID: 218853
		// (set) Token: 0x060356E6 RID: 218854
		int DelegateId { get; set; }
	}
}
