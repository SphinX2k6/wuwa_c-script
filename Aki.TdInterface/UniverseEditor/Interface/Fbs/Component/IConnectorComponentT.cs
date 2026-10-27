using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005001 RID: 20481
	public class IConnectorComponentT
	{
		// Token: 0x1700946E RID: 37998
		// (get) Token: 0x06020C13 RID: 134163 RVA: 0x0048E0ED File Offset: 0x0048C2ED
		// (set) Token: 0x06020C14 RID: 134164 RVA: 0x0048E0F5 File Offset: 0x0048C2F5
		public bool Disabled { get; set; }

		// Token: 0x1700946F RID: 37999
		// (get) Token: 0x06020C15 RID: 134165 RVA: 0x0048E0FE File Offset: 0x0048C2FE
		// (set) Token: 0x06020C16 RID: 134166 RVA: 0x0048E106 File Offset: 0x0048C306
		public TConnectorLogicUnion LogicType { get; set; }

		// Token: 0x17009470 RID: 38000
		// (get) Token: 0x06020C17 RID: 134167 RVA: 0x0048E10F File Offset: 0x0048C30F
		// (set) Token: 0x06020C18 RID: 134168 RVA: 0x0048E117 File Offset: 0x0048C317
		public byte NullMask { get; set; }

		// Token: 0x06020C19 RID: 134169 RVA: 0x0048E120 File Offset: 0x0048C320
		public IConnectorComponentT()
		{
			this.Disabled = false;
			this.LogicType = null;
			this.NullMask = 0;
		}
	}
}
