using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005004 RID: 20484
	public class IConnectorEffectConfigT
	{
		// Token: 0x17009475 RID: 38005
		// (get) Token: 0x06020C33 RID: 134195 RVA: 0x0048E452 File Offset: 0x0048C652
		// (set) Token: 0x06020C34 RID: 134196 RVA: 0x0048E45A File Offset: 0x0048C65A
		public string EffectPath { get; set; }

		// Token: 0x17009476 RID: 38006
		// (get) Token: 0x06020C35 RID: 134197 RVA: 0x0048E463 File Offset: 0x0048C663
		// (set) Token: 0x06020C36 RID: 134198 RVA: 0x0048E46B File Offset: 0x0048C66B
		public string StartPoint { get; set; }

		// Token: 0x17009477 RID: 38007
		// (get) Token: 0x06020C37 RID: 134199 RVA: 0x0048E474 File Offset: 0x0048C674
		// (set) Token: 0x06020C38 RID: 134200 RVA: 0x0048E47C File Offset: 0x0048C67C
		public string EndPoint { get; set; }

		// Token: 0x06020C39 RID: 134201 RVA: 0x0048E485 File Offset: 0x0048C685
		public IConnectorEffectConfigT()
		{
			this.EffectPath = null;
			this.StartPoint = null;
			this.EndPoint = null;
		}
	}
}
