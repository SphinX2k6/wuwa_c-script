using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C5 RID: 28869
	public class ILimitPlayerBlockAllT
	{
		// Token: 0x1700D379 RID: 54137
		// (get) Token: 0x0603221D RID: 205341 RVA: 0x006C8A3A File Offset: 0x006C6C3A
		// (set) Token: 0x0603221E RID: 205342 RVA: 0x006C8A42 File Offset: 0x006C6C42
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x0603221F RID: 205343 RVA: 0x006C8A4B File Offset: 0x006C6C4B
		public ILimitPlayerBlockAllT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
