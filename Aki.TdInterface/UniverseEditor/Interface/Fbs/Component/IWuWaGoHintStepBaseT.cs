using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB3 RID: 23475
	public class IWuWaGoHintStepBaseT
	{
		// Token: 0x1700B165 RID: 45413
		// (get) Token: 0x06028345 RID: 164677 RVA: 0x005864CA File Offset: 0x005846CA
		// (set) Token: 0x06028346 RID: 164678 RVA: 0x005864D2 File Offset: 0x005846D2
		public EWuWaGoHintStepType Type { get; set; }

		// Token: 0x06028347 RID: 164679 RVA: 0x005864DB File Offset: 0x005846DB
		public IWuWaGoHintStepBaseT()
		{
			this.Type = EWuWaGoHintStepType.Move;
		}
	}
}
