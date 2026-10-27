using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B64 RID: 27492
	public class IMoveToPosAT
	{
		// Token: 0x1700CC44 RID: 52292
		// (get) Token: 0x06030435 RID: 197685 RVA: 0x0068ECAF File Offset: 0x0068CEAF
		// (set) Token: 0x06030436 RID: 197686 RVA: 0x0068ECB7 File Offset: 0x0068CEB7
		public float Timeout { get; set; }

		// Token: 0x1700CC45 RID: 52293
		// (get) Token: 0x06030437 RID: 197687 RVA: 0x0068ECC0 File Offset: 0x0068CEC0
		// (set) Token: 0x06030438 RID: 197688 RVA: 0x0068ECC8 File Offset: 0x0068CEC8
		public IPosAT Pos { get; set; }

		// Token: 0x06030439 RID: 197689 RVA: 0x0068ECD1 File Offset: 0x0068CED1
		public IMoveToPosAT()
		{
			this.Timeout = 0f;
			this.Pos = null;
		}
	}
}
