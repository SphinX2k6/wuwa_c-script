using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064F6 RID: 25846
	public class ICustomAlertValueChangeSpeedT
	{
		// Token: 0x1700C03E RID: 49214
		// (get) Token: 0x0602CD63 RID: 183651 RVA: 0x00628FFC File Offset: 0x006271FC
		// (set) Token: 0x0602CD64 RID: 183652 RVA: 0x00629004 File Offset: 0x00627204
		public EValueChangeType Type { get; set; }

		// Token: 0x1700C03F RID: 49215
		// (get) Token: 0x0602CD65 RID: 183653 RVA: 0x0062900D File Offset: 0x0062720D
		// (set) Token: 0x0602CD66 RID: 183654 RVA: 0x00629015 File Offset: 0x00627215
		public float CustomValue { get; set; }

		// Token: 0x0602CD67 RID: 183655 RVA: 0x0062901E File Offset: 0x0062721E
		public ICustomAlertValueChangeSpeedT()
		{
			this.Type = EValueChangeType.AddOrSub;
			this.CustomValue = 0f;
		}
	}
}
