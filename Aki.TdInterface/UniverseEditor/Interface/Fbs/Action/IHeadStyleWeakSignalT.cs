using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F8A RID: 28554
	public class IHeadStyleWeakSignalT
	{
		// Token: 0x1700D120 RID: 53536
		// (get) Token: 0x060316C4 RID: 202436 RVA: 0x006B361E File Offset: 0x006B181E
		// (set) Token: 0x060316C5 RID: 202437 RVA: 0x006B3626 File Offset: 0x006B1826
		public EHeadStyle Type { get; set; }

		// Token: 0x060316C6 RID: 202438 RVA: 0x006B362F File Offset: 0x006B182F
		public IHeadStyleWeakSignalT()
		{
			this.Type = EHeadStyle.Normal;
		}
	}
}
