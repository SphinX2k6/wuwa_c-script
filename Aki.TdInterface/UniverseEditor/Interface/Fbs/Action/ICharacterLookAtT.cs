using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200633B RID: 25403
	public class ICharacterLookAtT
	{
		// Token: 0x1700BD96 RID: 48534
		// (get) Token: 0x0602BF1A RID: 179994 RVA: 0x0060A4C7 File Offset: 0x006086C7
		// (set) Token: 0x0602BF1B RID: 179995 RVA: 0x0060A4CF File Offset: 0x006086CF
		public int CharEntityId { get; set; }

		// Token: 0x1700BD97 RID: 48535
		// (get) Token: 0x0602BF1C RID: 179996 RVA: 0x0060A4D8 File Offset: 0x006086D8
		// (set) Token: 0x0602BF1D RID: 179997 RVA: 0x0060A4E0 File Offset: 0x006086E0
		public TCharacterLookAtDataUnion Target { get; set; }

		// Token: 0x0602BF1E RID: 179998 RVA: 0x0060A4E9 File Offset: 0x006086E9
		public ICharacterLookAtT()
		{
			this.CharEntityId = 0;
			this.Target = null;
		}
	}
}
