using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060FA RID: 24826
	[NullableContext(1)]
	public interface IRoverlikeBlessingSuitSelectParam
	{
		// Token: 0x17009159 RID: 37209
		// (get) Token: 0x0603EC6D RID: 257133
		// (set) Token: 0x0603EC6E RID: 257134
		List<IRoverlikeBlessingSuitData> SuitDataList { get; set; }

		// Token: 0x1700915A RID: 37210
		// (get) Token: 0x0603EC6F RID: 257135
		// (set) Token: 0x0603EC70 RID: 257136
		int SelectedIndex { get; set; }
	}
}
