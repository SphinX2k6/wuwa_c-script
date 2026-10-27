using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A51 RID: 27217
	public class ILongPressInteractStyleSwordRiderT
	{
		// Token: 0x1700C9EB RID: 51691
		// (get) Token: 0x0602FA7E RID: 195198 RVA: 0x0067C6FA File Offset: 0x0067A8FA
		// (set) Token: 0x0602FA7F RID: 195199 RVA: 0x0067C702 File Offset: 0x0067A902
		public ELongPressInteractStyle Type { get; set; }

		// Token: 0x0602FA80 RID: 195200 RVA: 0x0067C70B File Offset: 0x0067A90B
		public ILongPressInteractStyleSwordRiderT()
		{
			this.Type = ELongPressInteractStyle.Default;
		}
	}
}
