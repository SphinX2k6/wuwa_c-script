using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064F3 RID: 25843
	public class ICustomAlertValueT
	{
		// Token: 0x1700C039 RID: 49209
		// (get) Token: 0x0602CD4D RID: 183629 RVA: 0x00628DEC File Offset: 0x00626FEC
		// (set) Token: 0x0602CD4E RID: 183630 RVA: 0x00628DF4 File Offset: 0x00626FF4
		public EValueChangeType Type { get; set; }

		// Token: 0x1700C03A RID: 49210
		// (get) Token: 0x0602CD4F RID: 183631 RVA: 0x00628DFD File Offset: 0x00626FFD
		// (set) Token: 0x0602CD50 RID: 183632 RVA: 0x00628E05 File Offset: 0x00627005
		public float CustomValue { get; set; }

		// Token: 0x0602CD51 RID: 183633 RVA: 0x00628E0E File Offset: 0x0062700E
		public ICustomAlertValueT()
		{
			this.Type = EValueChangeType.AddOrSub;
			this.CustomValue = 0f;
		}
	}
}
