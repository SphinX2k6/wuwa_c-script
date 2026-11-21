using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A48 RID: 27208
	public class IClientFollowShooterResetToPlayerT
	{
		// Token: 0x1700C7E8 RID: 51176
		// (get) Token: 0x0602EABA RID: 191162 RVA: 0x0065C9B2 File Offset: 0x0065ABB2
		// (set) Token: 0x0602EABB RID: 191163 RVA: 0x0065C9BA File Offset: 0x0065ABBA
		public EClientFollowShooterLeisureInteractType Type { get; set; }

		// Token: 0x0602EABC RID: 191164 RVA: 0x0065C9C3 File Offset: 0x0065ABC3
		public IClientFollowShooterResetToPlayerT()
		{
			this.Type = EClientFollowShooterLeisureInteractType.PlayAnimation;
		}
	}
}
