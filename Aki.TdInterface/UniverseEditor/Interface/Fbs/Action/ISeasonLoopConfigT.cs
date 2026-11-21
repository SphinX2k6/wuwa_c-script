using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200770C RID: 30476
	public class ISeasonLoopConfigT
	{
		// Token: 0x1700DF82 RID: 57218
		// (get) Token: 0x06035793 RID: 219027 RVA: 0x0072B8C0 File Offset: 0x00729AC0
		// (set) Token: 0x06035794 RID: 219028 RVA: 0x0072B8C8 File Offset: 0x00729AC8
		public float HoldTime { get; set; }

		// Token: 0x1700DF83 RID: 57219
		// (get) Token: 0x06035795 RID: 219029 RVA: 0x0072B8D1 File Offset: 0x00729AD1
		// (set) Token: 0x06035796 RID: 219030 RVA: 0x0072B8D9 File Offset: 0x00729AD9
		public float SwitchTime { get; set; }

		// Token: 0x06035797 RID: 219031 RVA: 0x0072B8E2 File Offset: 0x00729AE2
		public ISeasonLoopConfigT()
		{
			this.HoldTime = 0f;
			this.SwitchTime = 0f;
		}
	}
}
