using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F16 RID: 28438
	public class ISafePosT
	{
		// Token: 0x1700D36C RID: 54124
		// (get) Token: 0x060323EB RID: 205803 RVA: 0x006C9B52 File Offset: 0x006C7D52
		// (set) Token: 0x060323EC RID: 205804 RVA: 0x006C9B5A File Offset: 0x006C7D5A
		public ETeleportType Type { get; set; }

		// Token: 0x1700D36D RID: 54125
		// (get) Token: 0x060323ED RID: 205805 RVA: 0x006C9B63 File Offset: 0x006C7D63
		// (set) Token: 0x060323EE RID: 205806 RVA: 0x006C9B6B File Offset: 0x006C7D6B
		public int FinalSafePosEntityId { get; set; }

		// Token: 0x1700D36E RID: 54126
		// (get) Token: 0x060323EF RID: 205807 RVA: 0x006C9B74 File Offset: 0x006C7D74
		// (set) Token: 0x060323F0 RID: 205808 RVA: 0x006C9B7C File Offset: 0x006C7D7C
		public byte NullMask { get; set; }

		// Token: 0x060323F1 RID: 205809 RVA: 0x006C9B85 File Offset: 0x006C7D85
		public ISafePosT()
		{
			this.Type = ETeleportType.FixedPos;
			this.FinalSafePosEntityId = 0;
			this.NullMask = 0;
		}
	}
}
