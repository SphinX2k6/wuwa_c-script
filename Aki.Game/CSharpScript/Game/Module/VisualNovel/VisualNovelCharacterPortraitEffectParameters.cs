using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037B5 RID: 14261
	public readonly struct VisualNovelCharacterPortraitEffectParameters
	{
		// Token: 0x17004C5C RID: 19548
		// (get) Token: 0x060251AA RID: 151978 RVA: 0x00A77D93 File Offset: 0x00A75F93
		public int CharacterId { get; }

		// Token: 0x17004C5D RID: 19549
		// (get) Token: 0x060251AB RID: 151979 RVA: 0x00A77D9B File Offset: 0x00A75F9B
		public EVisualNovelPortraitEffectType Effect { get; }

		// Token: 0x17004C5E RID: 19550
		// (get) Token: 0x060251AC RID: 151980 RVA: 0x00A77DA3 File Offset: 0x00A75FA3
		public float Distance { get; }

		// Token: 0x060251AD RID: 151981 RVA: 0x00A77DAB File Offset: 0x00A75FAB
		public VisualNovelCharacterPortraitEffectParameters(int characterId, EVisualNovelPortraitEffectType effect, float distance)
		{
			this.CharacterId = characterId;
			this.Effect = effect;
			this.Distance = distance;
		}
	}
}
