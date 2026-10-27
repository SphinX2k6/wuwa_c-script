using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063AD RID: 25517
	public class IClientEventTargetT
	{
		// Token: 0x1700BE34 RID: 48692
		// (get) Token: 0x0602C24D RID: 180813 RVA: 0x0060FE6A File Offset: 0x0060E06A
		// (set) Token: 0x0602C24E RID: 180814 RVA: 0x0060FE72 File Offset: 0x0060E072
		public EClientEventTarget Type { get; set; }

		// Token: 0x0602C24F RID: 180815 RVA: 0x0060FE7B File Offset: 0x0060E07B
		public IClientEventTargetT()
		{
			this.Type = EClientEventTarget.Self;
		}
	}
}
