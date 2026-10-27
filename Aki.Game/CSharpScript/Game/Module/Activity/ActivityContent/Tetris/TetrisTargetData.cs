using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FDB RID: 24539
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisTargetData : ITetrisTargetData
	{
		// Token: 0x17009029 RID: 36905
		// (get) Token: 0x0603E2CB RID: 254667 RVA: 0x00F02C4B File Offset: 0x00F00E4B
		// (set) Token: 0x0603E2CC RID: 254668 RVA: 0x00F02C53 File Offset: 0x00F00E53
		public string Icon { get; set; }

		// Token: 0x1700902A RID: 36906
		// (get) Token: 0x0603E2CD RID: 254669 RVA: 0x00F02C5C File Offset: 0x00F00E5C
		// (set) Token: 0x0603E2CE RID: 254670 RVA: 0x00F02C64 File Offset: 0x00F00E64
		public int Num { get; set; }

		// Token: 0x1700902B RID: 36907
		// (get) Token: 0x0603E2CF RID: 254671 RVA: 0x00F02C6D File Offset: 0x00F00E6D
		// (set) Token: 0x0603E2D0 RID: 254672 RVA: 0x00F02C75 File Offset: 0x00F00E75
		public string Tip { get; set; }
	}
}
