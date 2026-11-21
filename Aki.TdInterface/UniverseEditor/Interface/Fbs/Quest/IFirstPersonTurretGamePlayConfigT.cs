using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004290 RID: 17040
	public class IFirstPersonTurretGamePlayConfigT
	{
		// Token: 0x1700748E RID: 29838
		// (get) Token: 0x06017D84 RID: 97668 RVA: 0x0036806A File Offset: 0x0036626A
		// (set) Token: 0x06017D85 RID: 97669 RVA: 0x00368072 File Offset: 0x00366272
		public ESpecialGamePlayConfigType Type { get; set; }

		// Token: 0x06017D86 RID: 97670 RVA: 0x0036807B File Offset: 0x0036627B
		public IFirstPersonTurretGamePlayConfigT()
		{
			this.Type = ESpecialGamePlayConfigType.Stalking;
		}
	}
}
