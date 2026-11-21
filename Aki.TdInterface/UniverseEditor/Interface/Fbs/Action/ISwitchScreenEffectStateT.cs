using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A3B RID: 31291
	public class ISwitchScreenEffectStateT
	{
		// Token: 0x1700E543 RID: 58691
		// (get) Token: 0x06037248 RID: 225864 RVA: 0x0075DF77 File Offset: 0x0075C177
		// (set) Token: 0x06037249 RID: 225865 RVA: 0x0075DF7F File Offset: 0x0075C17F
		public ESwitchEffectStateEffectType Type { get; set; }

		// Token: 0x1700E544 RID: 58692
		// (get) Token: 0x0603724A RID: 225866 RVA: 0x0075DF88 File Offset: 0x0075C188
		// (set) Token: 0x0603724B RID: 225867 RVA: 0x0075DF90 File Offset: 0x0075C190
		public string Path { get; set; }

		// Token: 0x0603724C RID: 225868 RVA: 0x0075DF99 File Offset: 0x0075C199
		public ISwitchScreenEffectStateT()
		{
			this.Type = ESwitchEffectStateEffectType.ScreenEffect;
			this.Path = null;
		}
	}
}
