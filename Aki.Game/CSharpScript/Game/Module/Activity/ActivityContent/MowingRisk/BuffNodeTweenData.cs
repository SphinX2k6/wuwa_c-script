using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200535A RID: 21338
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffNodeTweenData
	{
		// Token: 0x1700676B RID: 26475
		// (get) Token: 0x06035186 RID: 217478 RVA: 0x00ED438F File Offset: 0x00ED258F
		// (set) Token: 0x06035187 RID: 217479 RVA: 0x00ED4397 File Offset: 0x00ED2597
		public float Percentage { get; set; }

		// Token: 0x1700676C RID: 26476
		// (get) Token: 0x06035188 RID: 217480 RVA: 0x00ED43A0 File Offset: 0x00ED25A0
		// (set) Token: 0x06035189 RID: 217481 RVA: 0x00ED43A8 File Offset: 0x00ED25A8
		public MowingBuffUnit BuffNodeItem { get; set; }

		// Token: 0x0603518A RID: 217482 RVA: 0x00ED43B1 File Offset: 0x00ED25B1
		public BuffNodeTweenData(float percentage, MowingBuffUnit buffNodeItem)
		{
			this.Percentage = percentage;
			this.BuffNodeItem = buffNodeItem;
		}
	}
}
