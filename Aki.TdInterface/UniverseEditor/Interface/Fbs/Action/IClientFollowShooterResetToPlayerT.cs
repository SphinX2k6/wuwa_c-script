using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063CB RID: 25547
	public class IClientFollowShooterResetToPlayerT
	{
		// Token: 0x1700BE57 RID: 48727
		// (get) Token: 0x0602C30F RID: 181007 RVA: 0x00611266 File Offset: 0x0060F466
		// (set) Token: 0x0602C310 RID: 181008 RVA: 0x0061126E File Offset: 0x0060F46E
		public EClientFollowShooterLeisureInteractType Type { get; set; }

		// Token: 0x0602C311 RID: 181009 RVA: 0x00611277 File Offset: 0x0060F477
		public IClientFollowShooterResetToPlayerT()
		{
			this.Type = EClientFollowShooterLeisureInteractType.ResetToPlayer;
		}
	}
}
