using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF1 RID: 23281
	public class ITriggerUe5ComponentT
	{
		// Token: 0x1700AFA0 RID: 44960
		// (get) Token: 0x06027BE0 RID: 162784 RVA: 0x00577885 File Offset: 0x00575A85
		// (set) Token: 0x06027BE1 RID: 162785 RVA: 0x0057788D File Offset: 0x00575A8D
		public bool Disabled { get; set; }

		// Token: 0x1700AFA1 RID: 44961
		// (get) Token: 0x06027BE2 RID: 162786 RVA: 0x00577896 File Offset: 0x00575A96
		// (set) Token: 0x06027BE3 RID: 162787 RVA: 0x0057789E File Offset: 0x00575A9E
		public int MaxTriggerTimes { get; set; }

		// Token: 0x1700AFA2 RID: 44962
		// (get) Token: 0x06027BE4 RID: 162788 RVA: 0x005778A7 File Offset: 0x00575AA7
		// (set) Token: 0x06027BE5 RID: 162789 RVA: 0x005778AF File Offset: 0x00575AAF
		public bool IsNotLoad { get; set; }

		// Token: 0x1700AFA3 RID: 44963
		// (get) Token: 0x06027BE6 RID: 162790 RVA: 0x005778B8 File Offset: 0x00575AB8
		// (set) Token: 0x06027BE7 RID: 162791 RVA: 0x005778C0 File Offset: 0x00575AC0
		public ITriggerActionsT TriggerActions { get; set; }

		// Token: 0x1700AFA4 RID: 44964
		// (get) Token: 0x06027BE8 RID: 162792 RVA: 0x005778C9 File Offset: 0x00575AC9
		// (set) Token: 0x06027BE9 RID: 162793 RVA: 0x005778D1 File Offset: 0x00575AD1
		public byte NullMask { get; set; }

		// Token: 0x06027BEA RID: 162794 RVA: 0x005778DA File Offset: 0x00575ADA
		public ITriggerUe5ComponentT()
		{
			this.Disabled = false;
			this.MaxTriggerTimes = 0;
			this.IsNotLoad = false;
			this.TriggerActions = null;
			this.NullMask = 0;
		}
	}
}
