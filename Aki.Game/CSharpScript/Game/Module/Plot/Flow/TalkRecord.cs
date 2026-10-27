using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x0200509A RID: 20634
	[NullableContext(1)]
	[Nullable(0)]
	public class TalkRecord
	{
		// Token: 0x17008089 RID: 32905
		// (get) Token: 0x06034E11 RID: 216593 RVA: 0x00C82BD3 File Offset: 0x00C80DD3
		// (set) Token: 0x06034E12 RID: 216594 RVA: 0x00C82BDB File Offset: 0x00C80DDB
		public ITalkItem TalkItem { get; set; }

		// Token: 0x1700808A RID: 32906
		// (get) Token: 0x06034E13 RID: 216595 RVA: 0x00C82BE4 File Offset: 0x00C80DE4
		// (set) Token: 0x06034E14 RID: 216596 RVA: 0x00C82BEC File Offset: 0x00C80DEC
		public bool IsOption { get; set; }

		// Token: 0x1700808B RID: 32907
		// (get) Token: 0x06034E15 RID: 216597 RVA: 0x00C82BF5 File Offset: 0x00C80DF5
		// (set) Token: 0x06034E16 RID: 216598 RVA: 0x00C82BFD File Offset: 0x00C80DFD
		public int? OptionIndex { get; set; }
	}
}
