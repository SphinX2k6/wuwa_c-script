using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060FB RID: 24827
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeBlessingSuitSelectParam : IRoverlikeBlessingSuitSelectParam
	{
		// Token: 0x1700915B RID: 37211
		// (get) Token: 0x0603EC71 RID: 257137 RVA: 0x00F29B66 File Offset: 0x00F27D66
		// (set) Token: 0x0603EC72 RID: 257138 RVA: 0x00F29B6E File Offset: 0x00F27D6E
		public List<IRoverlikeBlessingSuitData> SuitDataList { get; set; } = new List<IRoverlikeBlessingSuitData>();

		// Token: 0x1700915C RID: 37212
		// (get) Token: 0x0603EC73 RID: 257139 RVA: 0x00F29B77 File Offset: 0x00F27D77
		// (set) Token: 0x0603EC74 RID: 257140 RVA: 0x00F29B7F File Offset: 0x00F27D7F
		public int SelectedIndex { get; set; }
	}
}
