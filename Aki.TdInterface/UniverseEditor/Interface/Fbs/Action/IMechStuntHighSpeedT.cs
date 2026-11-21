using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071BD RID: 29117
	public class IMechStuntHighSpeedT
	{
		// Token: 0x1700D53E RID: 54590
		// (get) Token: 0x06032A62 RID: 207458 RVA: 0x006D7D9E File Offset: 0x006D5F9E
		// (set) Token: 0x06032A63 RID: 207459 RVA: 0x006D7DA6 File Offset: 0x006D5FA6
		public EMechStuntType Type { get; set; }

		// Token: 0x06032A64 RID: 207460 RVA: 0x006D7DAF File Offset: 0x006D5FAF
		public IMechStuntHighSpeedT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
