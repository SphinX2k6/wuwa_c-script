using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BB RID: 27067
	public class IItemFoundationMatchT
	{
		// Token: 0x1700C8C6 RID: 51398
		// (get) Token: 0x0602F4BF RID: 193727 RVA: 0x00671036 File Offset: 0x0066F236
		// (set) Token: 0x0602F4C0 RID: 193728 RVA: 0x0067103E File Offset: 0x0066F23E
		public int MatchEntityId { get; set; }

		// Token: 0x0602F4C1 RID: 193729 RVA: 0x00671047 File Offset: 0x0066F247
		public IItemFoundationMatchT()
		{
			this.MatchEntityId = 0;
		}
	}
}
