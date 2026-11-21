using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DD1 RID: 32209
	public class IVisualNovelPlayScreenEffectPersistentT
	{
		// Token: 0x1700F148 RID: 61768
		// (get) Token: 0x0603A34B RID: 238411 RVA: 0x007D864B File Offset: 0x007D684B
		// (set) Token: 0x0603A34C RID: 238412 RVA: 0x007D8653 File Offset: 0x007D6853
		public EVisualNovelScreenEffectType Type { get; set; }

		// Token: 0x1700F149 RID: 61769
		// (get) Token: 0x0603A34D RID: 238413 RVA: 0x007D865C File Offset: 0x007D685C
		// (set) Token: 0x0603A34E RID: 238414 RVA: 0x007D8664 File Offset: 0x007D6864
		public string PersistentEffectPath { get; set; }

		// Token: 0x0603A34F RID: 238415 RVA: 0x007D866D File Offset: 0x007D686D
		public IVisualNovelPlayScreenEffectPersistentT()
		{
			this.Type = EVisualNovelScreenEffectType.OneShot;
			this.PersistentEffectPath = null;
		}
	}
}
