using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B58 RID: 31576
	public class ITeleControlConfigT
	{
		// Token: 0x1700EC6C RID: 60524
		// (get) Token: 0x06038DC9 RID: 232905 RVA: 0x007B0054 File Offset: 0x007AE254
		// (set) Token: 0x06038DCA RID: 232906 RVA: 0x007B005C File Offset: 0x007AE25C
		public EExploreStateType Type { get; set; }

		// Token: 0x1700EC6D RID: 60525
		// (get) Token: 0x06038DCB RID: 232907 RVA: 0x007B0065 File Offset: 0x007AE265
		// (set) Token: 0x06038DCC RID: 232908 RVA: 0x007B006D File Offset: 0x007AE26D
		public ETeleControlType TeleControlType { get; set; }

		// Token: 0x06038DCD RID: 232909 RVA: 0x007B0076 File Offset: 0x007AE276
		public ITeleControlConfigT()
		{
			this.Type = EExploreStateType.TeleControl;
			this.TeleControlType = ETeleControlType.BigWorld;
		}
	}
}
