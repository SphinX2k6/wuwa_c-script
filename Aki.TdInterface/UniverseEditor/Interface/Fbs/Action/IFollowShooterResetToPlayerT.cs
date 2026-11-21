using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE5 RID: 28389
	public class IFollowShooterResetToPlayerT
	{
		// Token: 0x1700D02D RID: 53293
		// (get) Token: 0x060311DF RID: 201183 RVA: 0x006A8A9A File Offset: 0x006A6C9A
		// (set) Token: 0x060311E0 RID: 201184 RVA: 0x006A8AA2 File Offset: 0x006A6CA2
		public EFollowShooterLeisureInteractType Type { get; set; }

		// Token: 0x060311E1 RID: 201185 RVA: 0x006A8AAB File Offset: 0x006A6CAB
		public IFollowShooterResetToPlayerT()
		{
			this.Type = EFollowShooterLeisureInteractType.ResetToPlayer;
		}
	}
}
