using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x0200582A RID: 22570
	[NullableContext(1)]
	[Nullable(0)]
	public class CoopRoleSelectViewParams
	{
		// Token: 0x17006B19 RID: 27417
		// (get) Token: 0x06037AD6 RID: 228054 RVA: 0x00F908B2 File Offset: 0x00F8EAB2
		// (set) Token: 0x06037AD7 RID: 228055 RVA: 0x00F908BA File Offset: 0x00F8EABA
		public CoopActivityData ActivityData { get; set; }

		// Token: 0x17006B1A RID: 27418
		// (get) Token: 0x06037AD8 RID: 228056 RVA: 0x00F908C3 File Offset: 0x00F8EAC3
		// (set) Token: 0x06037AD9 RID: 228057 RVA: 0x00F908CB File Offset: 0x00F8EACB
		public int Index { get; set; }

		// Token: 0x17006B1B RID: 27419
		// (get) Token: 0x06037ADA RID: 228058 RVA: 0x00F908D4 File Offset: 0x00F8EAD4
		// (set) Token: 0x06037ADB RID: 228059 RVA: 0x00F908DC File Offset: 0x00F8EADC
		public int Level { get; set; }

		// Token: 0x17006B1C RID: 27420
		// (get) Token: 0x06037ADC RID: 228060 RVA: 0x00F908E5 File Offset: 0x00F8EAE5
		// (set) Token: 0x06037ADD RID: 228061 RVA: 0x00F908ED File Offset: 0x00F8EAED
		public int LevelId { get; set; }

		// Token: 0x17006B1D RID: 27421
		// (get) Token: 0x06037ADE RID: 228062 RVA: 0x00F908F6 File Offset: 0x00F8EAF6
		// (set) Token: 0x06037ADF RID: 228063 RVA: 0x00F908FE File Offset: 0x00F8EAFE
		public bool IsOpenByUpGradeView { get; set; }
	}
}
