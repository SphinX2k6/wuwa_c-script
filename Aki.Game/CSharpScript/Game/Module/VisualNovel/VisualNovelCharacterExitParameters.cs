using System;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037B3 RID: 14259
	public readonly struct VisualNovelCharacterExitParameters
	{
		// Token: 0x17004C56 RID: 19542
		// (get) Token: 0x060251A2 RID: 151970 RVA: 0x00A77D34 File Offset: 0x00A75F34
		public int CharacterId { get; }

		// Token: 0x17004C57 RID: 19543
		// (get) Token: 0x060251A3 RID: 151971 RVA: 0x00A77D3C File Offset: 0x00A75F3C
		public float Duration { get; }

		// Token: 0x060251A4 RID: 151972 RVA: 0x00A77D44 File Offset: 0x00A75F44
		public VisualNovelCharacterExitParameters(int characterId, float duration)
		{
			this.CharacterId = characterId;
			this.Duration = duration;
		}
	}
}
