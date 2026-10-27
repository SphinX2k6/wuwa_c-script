using System;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046A5 RID: 18085
	public class TouchData
	{
		// Token: 0x17007637 RID: 30263
		// (get) Token: 0x0602EA15 RID: 190997 RVA: 0x00ACBCA3 File Offset: 0x00AC9EA3
		// (set) Token: 0x0602EA16 RID: 190998 RVA: 0x00ACBCAB File Offset: 0x00AC9EAB
		public bool IsPress { get; set; }

		// Token: 0x17007638 RID: 30264
		// (get) Token: 0x0602EA17 RID: 190999 RVA: 0x00ACBCB4 File Offset: 0x00AC9EB4
		// (set) Token: 0x0602EA18 RID: 191000 RVA: 0x00ACBCBC File Offset: 0x00AC9EBC
		public int TouchId { get; set; }

		// Token: 0x17007639 RID: 30265
		// (get) Token: 0x0602EA19 RID: 191001 RVA: 0x00ACBCC5 File Offset: 0x00AC9EC5
		// (set) Token: 0x0602EA1A RID: 191002 RVA: 0x00ACBCCD File Offset: 0x00AC9ECD
		public FVector TouchPosition { get; set; }

		// Token: 0x0602EA1B RID: 191003 RVA: 0x00ACBCD6 File Offset: 0x00AC9ED6
		public TouchData(bool isPress, int touchId, FVector touchPosition)
		{
			this.IsPress = isPress;
			this.TouchId = touchId;
			this.TouchPosition = touchPosition;
		}
	}
}
