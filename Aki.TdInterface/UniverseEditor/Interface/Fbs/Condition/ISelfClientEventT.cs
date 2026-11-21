using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051BB RID: 20923
	public class ISelfClientEventT
	{
		// Token: 0x170095DE RID: 38366
		// (get) Token: 0x06020F15 RID: 134933 RVA: 0x0048E56A File Offset: 0x0048C76A
		// (set) Token: 0x06020F16 RID: 134934 RVA: 0x0048E572 File Offset: 0x0048C772
		public EClientEventTarget Type { get; set; }

		// Token: 0x06020F17 RID: 134935 RVA: 0x0048E57B File Offset: 0x0048C77B
		public ISelfClientEventT()
		{
			this.Type = EClientEventTarget.Self;
		}
	}
}
