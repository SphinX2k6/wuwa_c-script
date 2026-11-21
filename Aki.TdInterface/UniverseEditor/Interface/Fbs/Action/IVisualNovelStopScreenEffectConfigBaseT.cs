using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DE6 RID: 32230
	public class IVisualNovelStopScreenEffectConfigBaseT
	{
		// Token: 0x1700F177 RID: 61815
		// (get) Token: 0x0603A3FB RID: 238587 RVA: 0x007D97A6 File Offset: 0x007D79A6
		// (set) Token: 0x0603A3FC RID: 238588 RVA: 0x007D97AE File Offset: 0x007D79AE
		public EVisualNovelStopScreenEffectType Type { get; set; }

		// Token: 0x0603A3FD RID: 238589 RVA: 0x007D97B7 File Offset: 0x007D79B7
		public IVisualNovelStopScreenEffectConfigBaseT()
		{
			this.Type = EVisualNovelStopScreenEffectType.Persistent;
		}
	}
}
