using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E9E RID: 16030
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleMapFetterDescInfo : IRogueBattleMapFetterDescInfo
	{
		// Token: 0x170052CB RID: 21195
		// (get) Token: 0x06028B38 RID: 166712 RVA: 0x00B6A579 File Offset: 0x00B68779
		// (set) Token: 0x06028B39 RID: 166713 RVA: 0x00B6A581 File Offset: 0x00B68781
		public string TextId { get; set; } = string.Empty;

		// Token: 0x170052CC RID: 21196
		// (get) Token: 0x06028B3A RID: 166714 RVA: 0x00B6A58A File Offset: 0x00B6878A
		// (set) Token: 0x06028B3B RID: 166715 RVA: 0x00B6A592 File Offset: 0x00B68792
		[Nullable(2)]
		public string Param { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170052CD RID: 21197
		// (get) Token: 0x06028B3C RID: 166716 RVA: 0x00B6A59B File Offset: 0x00B6879B
		// (set) Token: 0x06028B3D RID: 166717 RVA: 0x00B6A5A3 File Offset: 0x00B687A3
		public bool IsReached { get; set; }

		// Token: 0x170052CE RID: 21198
		// (get) Token: 0x06028B3E RID: 166718 RVA: 0x00B6A5AC File Offset: 0x00B687AC
		// (set) Token: 0x06028B3F RID: 166719 RVA: 0x00B6A5B4 File Offset: 0x00B687B4
		public ERogueResBondEffectType EffectType { get; set; }
	}
}
