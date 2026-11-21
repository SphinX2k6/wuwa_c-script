using System;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035D6 RID: 13782
	public class TouchData
	{
		// Token: 0x170048F3 RID: 18675
		// (get) Token: 0x06023161 RID: 143713 RVA: 0x009FA577 File Offset: 0x009F8777
		// (set) Token: 0x06023162 RID: 143714 RVA: 0x009FA57F File Offset: 0x009F877F
		public bool IsPress { get; set; }

		// Token: 0x170048F4 RID: 18676
		// (get) Token: 0x06023163 RID: 143715 RVA: 0x009FA588 File Offset: 0x009F8788
		// (set) Token: 0x06023164 RID: 143716 RVA: 0x009FA590 File Offset: 0x009F8790
		public int TouchId { get; set; }

		// Token: 0x170048F5 RID: 18677
		// (get) Token: 0x06023165 RID: 143717 RVA: 0x009FA599 File Offset: 0x009F8799
		// (set) Token: 0x06023166 RID: 143718 RVA: 0x009FA5A1 File Offset: 0x009F87A1
		public FVector TouchPosition { get; set; }

		// Token: 0x06023167 RID: 143719 RVA: 0x009FA5AA File Offset: 0x009F87AA
		public TouchData(bool isPress, int touchId, FVector touchPosition)
		{
			this.IsPress = isPress;
			this.TouchId = touchId;
			this.TouchPosition = touchPosition;
		}
	}
}
