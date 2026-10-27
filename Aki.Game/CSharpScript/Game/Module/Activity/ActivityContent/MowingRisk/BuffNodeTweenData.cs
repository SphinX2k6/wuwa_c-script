using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063DC RID: 25564
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffNodeTweenData
	{
		// Token: 0x17009409 RID: 37897
		// (get) Token: 0x060404C5 RID: 263365 RVA: 0x00F8D3F7 File Offset: 0x00F8B5F7
		// (set) Token: 0x060404C6 RID: 263366 RVA: 0x00F8D3FF File Offset: 0x00F8B5FF
		public float Percentage { get; set; }

		// Token: 0x1700940A RID: 37898
		// (get) Token: 0x060404C7 RID: 263367 RVA: 0x00F8D408 File Offset: 0x00F8B608
		// (set) Token: 0x060404C8 RID: 263368 RVA: 0x00F8D410 File Offset: 0x00F8B610
		public MowingBuffUnit BuffNodeItem { get; set; }

		// Token: 0x060404C9 RID: 263369 RVA: 0x00F8D419 File Offset: 0x00F8B619
		public BuffNodeTweenData(float percentage, MowingBuffUnit buffNodeItem)
		{
			this.Percentage = percentage;
			this.BuffNodeItem = buffNodeItem;
		}
	}
}
