using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006350 RID: 25424
	public class ICharacterLookAtUnlockDataT
	{
		// Token: 0x1700BDAF RID: 48559
		// (get) Token: 0x0602BFA4 RID: 180132 RVA: 0x0060B19A File Offset: 0x0060939A
		// (set) Token: 0x0602BFA5 RID: 180133 RVA: 0x0060B1A2 File Offset: 0x006093A2
		public ECharacterLookAt Type { get; set; }

		// Token: 0x0602BFA6 RID: 180134 RVA: 0x0060B1AB File Offset: 0x006093AB
		public ICharacterLookAtUnlockDataT()
		{
			this.Type = ECharacterLookAt.Empty;
		}
	}
}
