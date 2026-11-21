using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D4A RID: 23882
	public class IPilotThrowTargetT
	{
		// Token: 0x1700AFCE RID: 45006
		// (get) Token: 0x06027C05 RID: 162821 RVA: 0x005708E2 File Offset: 0x0056EAE2
		// (set) Token: 0x06027C06 RID: 162822 RVA: 0x005708EA File Offset: 0x0056EAEA
		public string TidTargetName { get; set; }

		// Token: 0x1700AFCF RID: 45007
		// (get) Token: 0x06027C07 RID: 162823 RVA: 0x005708F3 File Offset: 0x0056EAF3
		// (set) Token: 0x06027C08 RID: 162824 RVA: 0x005708FB File Offset: 0x0056EAFB
		public IVectorInfoT Position { get; set; }

		// Token: 0x1700AFD0 RID: 45008
		// (get) Token: 0x06027C09 RID: 162825 RVA: 0x00570904 File Offset: 0x0056EB04
		// (set) Token: 0x06027C0A RID: 162826 RVA: 0x0057090C File Offset: 0x0056EB0C
		public EPilotThrowPointVisualType VisualType { get; set; }

		// Token: 0x1700AFD1 RID: 45009
		// (get) Token: 0x06027C0B RID: 162827 RVA: 0x00570915 File Offset: 0x0056EB15
		// (set) Token: 0x06027C0C RID: 162828 RVA: 0x0057091D File Offset: 0x0056EB1D
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x1700AFD2 RID: 45010
		// (get) Token: 0x06027C0D RID: 162829 RVA: 0x00570926 File Offset: 0x0056EB26
		// (set) Token: 0x06027C0E RID: 162830 RVA: 0x0057092E File Offset: 0x0056EB2E
		public bool IsQuest { get; set; }

		// Token: 0x1700AFD3 RID: 45011
		// (get) Token: 0x06027C0F RID: 162831 RVA: 0x00570937 File Offset: 0x0056EB37
		// (set) Token: 0x06027C10 RID: 162832 RVA: 0x0057093F File Offset: 0x0056EB3F
		public float UiScale { get; set; }

		// Token: 0x1700AFD4 RID: 45012
		// (get) Token: 0x06027C11 RID: 162833 RVA: 0x00570948 File Offset: 0x0056EB48
		// (set) Token: 0x06027C12 RID: 162834 RVA: 0x00570950 File Offset: 0x0056EB50
		public byte NullMask { get; set; }

		// Token: 0x06027C13 RID: 162835 RVA: 0x00570959 File Offset: 0x0056EB59
		public IPilotThrowTargetT()
		{
			this.TidTargetName = null;
			this.Position = null;
			this.VisualType = EPilotThrowPointVisualType.Normal;
			this.Conditions = null;
			this.IsQuest = false;
			this.UiScale = 0f;
			this.NullMask = 0;
		}
	}
}
