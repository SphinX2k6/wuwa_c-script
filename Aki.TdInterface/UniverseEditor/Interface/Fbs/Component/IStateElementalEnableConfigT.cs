using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FB5 RID: 24501
	public class IStateElementalEnableConfigT
	{
		// Token: 0x1700B576 RID: 46454
		// (get) Token: 0x0602938E RID: 168846 RVA: 0x005A08D3 File Offset: 0x0059EAD3
		// (set) Token: 0x0602938F RID: 168847 RVA: 0x005A08DB File Offset: 0x0059EADB
		public string State { get; set; }

		// Token: 0x1700B577 RID: 46455
		// (get) Token: 0x06029390 RID: 168848 RVA: 0x005A08E4 File Offset: 0x0059EAE4
		// (set) Token: 0x06029391 RID: 168849 RVA: 0x005A08EC File Offset: 0x0059EAEC
		public bool ElementalEnable { get; set; }

		// Token: 0x06029392 RID: 168850 RVA: 0x005A08F5 File Offset: 0x0059EAF5
		public IStateElementalEnableConfigT()
		{
			this.State = null;
			this.ElementalEnable = false;
		}
	}
}
