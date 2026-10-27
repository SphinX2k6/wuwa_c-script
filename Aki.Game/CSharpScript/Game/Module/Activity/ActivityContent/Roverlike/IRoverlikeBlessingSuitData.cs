using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060F8 RID: 24824
	[NullableContext(1)]
	public interface IRoverlikeBlessingSuitData
	{
		// Token: 0x17009155 RID: 37205
		// (get) Token: 0x0603EC64 RID: 257124
		// (set) Token: 0x0603EC65 RID: 257125
		int SuitId { get; set; }

		// Token: 0x17009156 RID: 37206
		// (get) Token: 0x0603EC66 RID: 257126
		// (set) Token: 0x0603EC67 RID: 257127
		List<int> BlessingIdList { get; set; }
	}
}
