using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200725D RID: 29277
	public class ISwitchEffectStateEffectBaseT
	{
		// Token: 0x1700D93D RID: 55613
		// (get) Token: 0x06033F02 RID: 212738 RVA: 0x006FC4F2 File Offset: 0x006FA6F2
		// (set) Token: 0x06033F03 RID: 212739 RVA: 0x006FC4FA File Offset: 0x006FA6FA
		public ESwitchEffectStateEffectType Type { get; set; }

		// Token: 0x06033F04 RID: 212740 RVA: 0x006FC503 File Offset: 0x006FA703
		public ISwitchEffectStateEffectBaseT()
		{
			this.Type = ESwitchEffectStateEffectType.ScreenEffect;
		}
	}
}
