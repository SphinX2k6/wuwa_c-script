using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007891 RID: 30865
	public class ISheriffReasoningT
	{
		// Token: 0x1700E259 RID: 57945
		// (get) Token: 0x060364C6 RID: 222406 RVA: 0x00745890 File Offset: 0x00743A90
		// (set) Token: 0x060364C7 RID: 222407 RVA: 0x00745898 File Offset: 0x00743A98
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700E25A RID: 57946
		// (get) Token: 0x060364C8 RID: 222408 RVA: 0x007458A1 File Offset: 0x00743AA1
		// (set) Token: 0x060364C9 RID: 222409 RVA: 0x007458A9 File Offset: 0x00743AA9
		public int Id { get; set; }

		// Token: 0x060364CA RID: 222410 RVA: 0x007458B2 File Offset: 0x00743AB2
		public ISheriffReasoningT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.Id = 0;
		}
	}
}
