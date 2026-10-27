using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FD1 RID: 24529
	[NullableContext(1)]
	[Nullable(0)]
	public class ShapeConfig : IShapeConfig
	{
		// Token: 0x17009001 RID: 36865
		// (get) Token: 0x0603E276 RID: 254582 RVA: 0x00F02ACF File Offset: 0x00F00CCF
		// (set) Token: 0x0603E277 RID: 254583 RVA: 0x00F02AD7 File Offset: 0x00F00CD7
		public int Id { get; set; }

		// Token: 0x17009002 RID: 36866
		// (get) Token: 0x0603E278 RID: 254584 RVA: 0x00F02AE0 File Offset: 0x00F00CE0
		// (set) Token: 0x0603E279 RID: 254585 RVA: 0x00F02AE8 File Offset: 0x00F00CE8
		public int[][] Matrix { get; set; }

		// Token: 0x17009003 RID: 36867
		// (get) Token: 0x0603E27A RID: 254586 RVA: 0x00F02AF1 File Offset: 0x00F00CF1
		// (set) Token: 0x0603E27B RID: 254587 RVA: 0x00F02AF9 File Offset: 0x00F00CF9
		public int Weight { get; set; }
	}
}
