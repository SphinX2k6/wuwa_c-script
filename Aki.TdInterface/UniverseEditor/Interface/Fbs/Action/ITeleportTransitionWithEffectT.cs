using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B6 RID: 29622
	public class ITeleportTransitionWithEffectT
	{
		// Token: 0x1700E0E7 RID: 57575
		// (get) Token: 0x06035C8E RID: 220302 RVA: 0x0075225F File Offset: 0x0075045F
		// (set) Token: 0x06035C8F RID: 220303 RVA: 0x00752267 File Offset: 0x00750467
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700E0E8 RID: 57576
		// (get) Token: 0x06035C90 RID: 220304 RVA: 0x00752270 File Offset: 0x00750470
		// (set) Token: 0x06035C91 RID: 220305 RVA: 0x00752278 File Offset: 0x00750478
		public string EffectDaPath { get; set; }

		// Token: 0x06035C92 RID: 220306 RVA: 0x00752281 File Offset: 0x00750481
		public ITeleportTransitionWithEffectT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.EffectDaPath = null;
		}
	}
}
