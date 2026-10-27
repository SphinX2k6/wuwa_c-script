using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E5A RID: 20058
	public class IAddBuffModeT
	{
		// Token: 0x17008F8F RID: 36751
		// (get) Token: 0x0601F7DC RID: 128988 RVA: 0x00462F72 File Offset: 0x00461172
		// (set) Token: 0x0601F7DD RID: 128989 RVA: 0x00462F7A File Offset: 0x0046117A
		public EBuffProducerMode Type { get; set; }

		// Token: 0x0601F7DE RID: 128990 RVA: 0x00462F83 File Offset: 0x00461183
		public IAddBuffModeT()
		{
			this.Type = EBuffProducerMode.Immediate;
		}
	}
}
