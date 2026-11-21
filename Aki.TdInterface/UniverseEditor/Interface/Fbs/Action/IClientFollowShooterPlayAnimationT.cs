using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A42 RID: 27202
	public class IClientFollowShooterPlayAnimationT
	{
		// Token: 0x1700C7DF RID: 51167
		// (get) Token: 0x0602EA90 RID: 191120 RVA: 0x0065C617 File Offset: 0x0065A817
		// (set) Token: 0x0602EA91 RID: 191121 RVA: 0x0065C61F File Offset: 0x0065A81F
		public EClientFollowShooterLeisureInteractType Type { get; set; }

		// Token: 0x1700C7E0 RID: 51168
		// (get) Token: 0x0602EA92 RID: 191122 RVA: 0x0065C628 File Offset: 0x0065A828
		// (set) Token: 0x0602EA93 RID: 191123 RVA: 0x0065C630 File Offset: 0x0065A830
		public string Montage { get; set; }

		// Token: 0x0602EA94 RID: 191124 RVA: 0x0065C639 File Offset: 0x0065A839
		public IClientFollowShooterPlayAnimationT()
		{
			this.Type = EClientFollowShooterLeisureInteractType.PlayAnimation;
			this.Montage = null;
		}
	}
}
