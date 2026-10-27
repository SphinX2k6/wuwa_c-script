using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing
{
	// Token: 0x02006479 RID: 25721
	[NullableContext(1)]
	public interface IBusinessTipsTravelData
	{
		// Token: 0x170094A1 RID: 38049
		// (get) Token: 0x06040A1D RID: 264733
		// (set) Token: 0x06040A1E RID: 264734
		List<int> RoleList { get; set; }

		// Token: 0x170094A2 RID: 38050
		// (get) Token: 0x06040A1F RID: 264735
		// (set) Token: 0x06040A20 RID: 264736
		List<int> LastLevelList { get; set; }

		// Token: 0x170094A3 RID: 38051
		// (get) Token: 0x06040A21 RID: 264737
		// (set) Token: 0x06040A22 RID: 264738
		int DelegateId { get; set; }
	}
}
