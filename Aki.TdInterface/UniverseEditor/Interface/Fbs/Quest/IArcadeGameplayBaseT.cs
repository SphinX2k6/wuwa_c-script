using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004119 RID: 16665
	public class IArcadeGameplayBaseT
	{
		// Token: 0x170070E5 RID: 28901
		// (get) Token: 0x06016DE9 RID: 93673 RVA: 0x00344166 File Offset: 0x00342366
		// (set) Token: 0x06016DEA RID: 93674 RVA: 0x0034416E File Offset: 0x0034236E
		public EArcadeGameplayType Type { get; set; }

		// Token: 0x06016DEB RID: 93675 RVA: 0x00344177 File Offset: 0x00342377
		public IArcadeGameplayBaseT()
		{
			this.Type = EArcadeGameplayType.DropCatch;
		}
	}
}
