using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053EA RID: 21482
	public class IImmediateAddBuffT
	{
		// Token: 0x17009E1E RID: 40478
		// (get) Token: 0x06023479 RID: 144505 RVA: 0x004E2922 File Offset: 0x004E0B22
		// (set) Token: 0x0602347A RID: 144506 RVA: 0x004E292A File Offset: 0x004E0B2A
		public EBuffProducerMode Type { get; set; }

		// Token: 0x0602347B RID: 144507 RVA: 0x004E2933 File Offset: 0x004E0B33
		public IImmediateAddBuffT()
		{
			this.Type = EBuffProducerMode.Immediate;
		}
	}
}
