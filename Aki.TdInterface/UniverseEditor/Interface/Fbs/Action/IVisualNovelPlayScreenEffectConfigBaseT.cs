using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DC5 RID: 32197
	public class IVisualNovelPlayScreenEffectConfigBaseT
	{
		// Token: 0x1700F138 RID: 61752
		// (get) Token: 0x0603A2F7 RID: 238327 RVA: 0x007D7E7A File Offset: 0x007D607A
		// (set) Token: 0x0603A2F8 RID: 238328 RVA: 0x007D7E82 File Offset: 0x007D6082
		public EVisualNovelScreenEffectType Type { get; set; }

		// Token: 0x0603A2F9 RID: 238329 RVA: 0x007D7E8B File Offset: 0x007D608B
		public IVisualNovelPlayScreenEffectConfigBaseT()
		{
			this.Type = EVisualNovelScreenEffectType.OneShot;
		}
	}
}
