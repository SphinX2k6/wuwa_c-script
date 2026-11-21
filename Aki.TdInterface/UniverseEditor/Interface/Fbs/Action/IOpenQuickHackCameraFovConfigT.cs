using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200738C RID: 29580
	public class IOpenQuickHackCameraFovConfigT
	{
		// Token: 0x1700D904 RID: 55556
		// (get) Token: 0x06033A65 RID: 211557 RVA: 0x006F653A File Offset: 0x006F473A
		// (set) Token: 0x06033A66 RID: 211558 RVA: 0x006F6542 File Offset: 0x006F4742
		public int DefaultValue { get; set; }

		// Token: 0x1700D905 RID: 55557
		// (get) Token: 0x06033A67 RID: 211559 RVA: 0x006F654B File Offset: 0x006F474B
		// (set) Token: 0x06033A68 RID: 211560 RVA: 0x006F6553 File Offset: 0x006F4753
		public int Min { get; set; }

		// Token: 0x1700D906 RID: 55558
		// (get) Token: 0x06033A69 RID: 211561 RVA: 0x006F655C File Offset: 0x006F475C
		// (set) Token: 0x06033A6A RID: 211562 RVA: 0x006F6564 File Offset: 0x006F4764
		public int Max { get; set; }

		// Token: 0x06033A6B RID: 211563 RVA: 0x006F656D File Offset: 0x006F476D
		public IOpenQuickHackCameraFovConfigT()
		{
			this.DefaultValue = 0;
			this.Min = 0;
			this.Max = 0;
		}
	}
}
