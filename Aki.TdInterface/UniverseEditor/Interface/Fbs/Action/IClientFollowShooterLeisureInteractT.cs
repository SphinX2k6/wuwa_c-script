using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A39 RID: 27193
	public class IClientFollowShooterLeisureInteractT
	{
		// Token: 0x1700C7D5 RID: 51157
		// (get) Token: 0x0602EA56 RID: 191062 RVA: 0x0065C0AB File Offset: 0x0065A2AB
		// (set) Token: 0x0602EA57 RID: 191063 RVA: 0x0065C0B3 File Offset: 0x0065A2B3
		public int Id { get; set; }

		// Token: 0x1700C7D6 RID: 51158
		// (get) Token: 0x0602EA58 RID: 191064 RVA: 0x0065C0BC File Offset: 0x0065A2BC
		// (set) Token: 0x0602EA59 RID: 191065 RVA: 0x0065C0C4 File Offset: 0x0065A2C4
		public TClientFollowShooterLeisureTypeUnion InteractType { get; set; }

		// Token: 0x0602EA5A RID: 191066 RVA: 0x0065C0CD File Offset: 0x0065A2CD
		public IClientFollowShooterLeisureInteractT()
		{
			this.Id = 0;
			this.InteractType = null;
		}
	}
}
