using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073DD RID: 29661
	public class ITimeLimitOptionGroupBaseStyleT
	{
		// Token: 0x1700E154 RID: 57684
		// (get) Token: 0x06035E2D RID: 220717 RVA: 0x00755946 File Offset: 0x00753B46
		// (set) Token: 0x06035E2E RID: 220718 RVA: 0x0075594E File Offset: 0x00753B4E
		public ETimeLimitOptionGroupStyle Type { get; set; }

		// Token: 0x06035E2F RID: 220719 RVA: 0x00755957 File Offset: 0x00753B57
		public ITimeLimitOptionGroupBaseStyleT()
		{
			this.Type = ETimeLimitOptionGroupStyle.Default;
		}
	}
}
