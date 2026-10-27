using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A7C RID: 19068
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseMarkInfo : ITrapDefenseMarkInfo
	{
		// Token: 0x17007AD9 RID: 31449
		// (get) Token: 0x0603169F RID: 202399 RVA: 0x00B728F4 File Offset: 0x00B70AF4
		// (set) Token: 0x060316A0 RID: 202400 RVA: 0x00B728FC File Offset: 0x00B70AFC
		public int MarkId { get; set; }

		// Token: 0x17007ADA RID: 31450
		// (get) Token: 0x060316A1 RID: 202401 RVA: 0x00B72905 File Offset: 0x00B70B05
		// (set) Token: 0x060316A2 RID: 202402 RVA: 0x00B7290D File Offset: 0x00B70B0D
		public TrapDefenseDefine.ETrapDefenseMarkType MarkType { get; set; }

		// Token: 0x17007ADB RID: 31451
		// (get) Token: 0x060316A3 RID: 202403 RVA: 0x00B72916 File Offset: 0x00B70B16
		// (set) Token: 0x060316A4 RID: 202404 RVA: 0x00B7291E File Offset: 0x00B70B1E
		public object ExtraParam { get; set; }
	}
}
