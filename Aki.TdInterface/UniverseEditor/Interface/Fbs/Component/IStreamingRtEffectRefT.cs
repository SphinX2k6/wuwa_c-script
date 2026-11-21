using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FDF RID: 24543
	public class IStreamingRtEffectRefT
	{
		// Token: 0x1700B5FE RID: 46590
		// (get) Token: 0x060295A0 RID: 169376 RVA: 0x005A5455 File Offset: 0x005A3655
		// (set) Token: 0x060295A1 RID: 169377 RVA: 0x005A545D File Offset: 0x005A365D
		public string ActorRefKey { get; set; }

		// Token: 0x060295A2 RID: 169378 RVA: 0x005A5466 File Offset: 0x005A3666
		public IStreamingRtEffectRefT()
		{
			this.ActorRefKey = null;
		}
	}
}
