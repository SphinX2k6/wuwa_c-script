using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FB9 RID: 20409
	public class ICollisionChannelConfigT
	{
		// Token: 0x170093D3 RID: 37843
		// (get) Token: 0x060207D7 RID: 133079 RVA: 0x00485135 File Offset: 0x00483335
		// (set) Token: 0x060207D8 RID: 133080 RVA: 0x0048513D File Offset: 0x0048333D
		public IOverrideCollisionChannelT OverrideCollisionChannel { get; set; }

		// Token: 0x060207D9 RID: 133081 RVA: 0x00485146 File Offset: 0x00483346
		public ICollisionChannelConfigT()
		{
			this.OverrideCollisionChannel = null;
		}
	}
}
