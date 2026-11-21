using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005515 RID: 21781
	public class ICollisionChannelConfigT
	{
		// Token: 0x17009BAB RID: 39851
		// (get) Token: 0x060226CB RID: 141003 RVA: 0x004BE619 File Offset: 0x004BC819
		// (set) Token: 0x060226CC RID: 141004 RVA: 0x004BE621 File Offset: 0x004BC821
		public IOverrideCollisionChannelT OverrideCollisionChannel { get; set; }

		// Token: 0x060226CD RID: 141005 RVA: 0x004BE62A File Offset: 0x004BC82A
		public ICollisionChannelConfigT()
		{
			this.OverrideCollisionChannel = null;
		}
	}
}
