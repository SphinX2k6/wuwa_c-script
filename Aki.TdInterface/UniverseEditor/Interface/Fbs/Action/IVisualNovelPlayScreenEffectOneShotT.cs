using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DCE RID: 32206
	public class IVisualNovelPlayScreenEffectOneShotT
	{
		// Token: 0x1700F143 RID: 61763
		// (get) Token: 0x0603A333 RID: 238387 RVA: 0x007D8417 File Offset: 0x007D6617
		// (set) Token: 0x0603A334 RID: 238388 RVA: 0x007D841F File Offset: 0x007D661F
		public EVisualNovelScreenEffectType Type { get; set; }

		// Token: 0x1700F144 RID: 61764
		// (get) Token: 0x0603A335 RID: 238389 RVA: 0x007D8428 File Offset: 0x007D6628
		// (set) Token: 0x0603A336 RID: 238390 RVA: 0x007D8430 File Offset: 0x007D6630
		public string OneShotEffectPath { get; set; }

		// Token: 0x0603A337 RID: 238391 RVA: 0x007D8439 File Offset: 0x007D6639
		public IVisualNovelPlayScreenEffectOneShotT()
		{
			this.Type = EVisualNovelScreenEffectType.OneShot;
			this.OneShotEffectPath = null;
		}
	}
}
