using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EDF RID: 28383
	public class IFollowShooterLeisureInteractTypeT
	{
		// Token: 0x1700D028 RID: 53288
		// (get) Token: 0x060311BF RID: 201151 RVA: 0x006A87DA File Offset: 0x006A69DA
		// (set) Token: 0x060311C0 RID: 201152 RVA: 0x006A87E2 File Offset: 0x006A69E2
		public EFollowShooterLeisureInteractType Type { get; set; }

		// Token: 0x060311C1 RID: 201153 RVA: 0x006A87EB File Offset: 0x006A69EB
		public IFollowShooterLeisureInteractTypeT()
		{
			this.Type = EFollowShooterLeisureInteractType.ResetToPlayer;
		}
	}
}
