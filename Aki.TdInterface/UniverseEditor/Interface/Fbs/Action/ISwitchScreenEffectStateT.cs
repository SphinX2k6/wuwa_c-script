using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007266 RID: 29286
	public class ISwitchScreenEffectStateT
	{
		// Token: 0x1700D94A RID: 55626
		// (get) Token: 0x06033F46 RID: 212806 RVA: 0x006FCC17 File Offset: 0x006FAE17
		// (set) Token: 0x06033F47 RID: 212807 RVA: 0x006FCC1F File Offset: 0x006FAE1F
		public ESwitchEffectStateEffectType Type { get; set; }

		// Token: 0x1700D94B RID: 55627
		// (get) Token: 0x06033F48 RID: 212808 RVA: 0x006FCC28 File Offset: 0x006FAE28
		// (set) Token: 0x06033F49 RID: 212809 RVA: 0x006FCC30 File Offset: 0x006FAE30
		public string Path { get; set; }

		// Token: 0x06033F4A RID: 212810 RVA: 0x006FCC39 File Offset: 0x006FAE39
		public ISwitchScreenEffectStateT()
		{
			this.Type = ESwitchEffectStateEffectType.ScreenEffect;
			this.Path = null;
		}
	}
}
