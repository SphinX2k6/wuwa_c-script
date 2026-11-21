using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200769D RID: 30365
	public class ISafePosT
	{
		// Token: 0x1700DEC8 RID: 57032
		// (get) Token: 0x06035443 RID: 218179 RVA: 0x00725ABA File Offset: 0x00723CBA
		// (set) Token: 0x06035444 RID: 218180 RVA: 0x00725AC2 File Offset: 0x00723CC2
		public ETeleportType Type { get; set; }

		// Token: 0x1700DEC9 RID: 57033
		// (get) Token: 0x06035445 RID: 218181 RVA: 0x00725ACB File Offset: 0x00723CCB
		// (set) Token: 0x06035446 RID: 218182 RVA: 0x00725AD3 File Offset: 0x00723CD3
		public int FinalSafePosEntityId { get; set; }

		// Token: 0x1700DECA RID: 57034
		// (get) Token: 0x06035447 RID: 218183 RVA: 0x00725ADC File Offset: 0x00723CDC
		// (set) Token: 0x06035448 RID: 218184 RVA: 0x00725AE4 File Offset: 0x00723CE4
		public byte NullMask { get; set; }

		// Token: 0x06035449 RID: 218185 RVA: 0x00725AED File Offset: 0x00723CED
		public ISafePosT()
		{
			this.Type = ETeleportType.FixedPos;
			this.FinalSafePosEntityId = 0;
			this.NullMask = 0;
		}
	}
}
