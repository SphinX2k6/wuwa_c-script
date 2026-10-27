using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007371 RID: 29553
	public class ITeleControlConfigT
	{
		// Token: 0x1700E05C RID: 57436
		// (get) Token: 0x06035A2E RID: 219694 RVA: 0x0074DB14 File Offset: 0x0074BD14
		// (set) Token: 0x06035A2F RID: 219695 RVA: 0x0074DB1C File Offset: 0x0074BD1C
		public EExploreStateType Type { get; set; }

		// Token: 0x1700E05D RID: 57437
		// (get) Token: 0x06035A30 RID: 219696 RVA: 0x0074DB25 File Offset: 0x0074BD25
		// (set) Token: 0x06035A31 RID: 219697 RVA: 0x0074DB2D File Offset: 0x0074BD2D
		public ETeleControlType TeleControlType { get; set; }

		// Token: 0x06035A32 RID: 219698 RVA: 0x0074DB36 File Offset: 0x0074BD36
		public ITeleControlConfigT()
		{
			this.Type = EExploreStateType.TeleControl;
			this.TeleControlType = ETeleControlType.BigWorld;
		}
	}
}
