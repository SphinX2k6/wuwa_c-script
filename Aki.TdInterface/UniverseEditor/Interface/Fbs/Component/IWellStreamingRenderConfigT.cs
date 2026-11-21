using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006188 RID: 24968
	public class IWellStreamingRenderConfigT
	{
		// Token: 0x1700BA2F RID: 47663
		// (get) Token: 0x0602A6D5 RID: 173781 RVA: 0x005C9C2B File Offset: 0x005C7E2B
		// (set) Token: 0x0602A6D6 RID: 173782 RVA: 0x005C9C33 File Offset: 0x005C7E33
		public IWellStreamingRenderSelfConfigT SelfConfig { get; set; }

		// Token: 0x1700BA30 RID: 47664
		// (get) Token: 0x0602A6D7 RID: 173783 RVA: 0x005C9C3C File Offset: 0x005C7E3C
		// (set) Token: 0x0602A6D8 RID: 173784 RVA: 0x005C9C44 File Offset: 0x005C7E44
		public IWellStreamingRenderPointConfigT AsStreamPointConfig { get; set; }

		// Token: 0x0602A6D9 RID: 173785 RVA: 0x005C9C4D File Offset: 0x005C7E4D
		public IWellStreamingRenderConfigT()
		{
			this.SelfConfig = null;
			this.AsStreamPointConfig = null;
		}
	}
}
