using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053AB RID: 21419
	public class IHoldCfgT
	{
		// Token: 0x17009D5D RID: 40285
		// (get) Token: 0x06023160 RID: 143712 RVA: 0x004DB62D File Offset: 0x004D982D
		// (set) Token: 0x06023161 RID: 143713 RVA: 0x004DB635 File Offset: 0x004D9835
		public IHoldingTrackTargetT TrackTarget { get; set; }

		// Token: 0x06023162 RID: 143714 RVA: 0x004DB63E File Offset: 0x004D983E
		public IHoldCfgT()
		{
			this.TrackTarget = null;
		}
	}
}
