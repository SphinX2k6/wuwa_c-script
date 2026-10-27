using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060F9 RID: 24825
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeBlessingSuitData : IRoverlikeBlessingSuitData
	{
		// Token: 0x17009157 RID: 37207
		// (get) Token: 0x0603EC68 RID: 257128 RVA: 0x00F29B31 File Offset: 0x00F27D31
		// (set) Token: 0x0603EC69 RID: 257129 RVA: 0x00F29B39 File Offset: 0x00F27D39
		public int SuitId { get; set; }

		// Token: 0x17009158 RID: 37208
		// (get) Token: 0x0603EC6A RID: 257130 RVA: 0x00F29B42 File Offset: 0x00F27D42
		// (set) Token: 0x0603EC6B RID: 257131 RVA: 0x00F29B4A File Offset: 0x00F27D4A
		public List<int> BlessingIdList { get; set; } = new List<int>();
	}
}
