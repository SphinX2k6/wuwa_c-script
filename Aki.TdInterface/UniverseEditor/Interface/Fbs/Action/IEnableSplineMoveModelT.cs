using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006688 RID: 26248
	public class IEnableSplineMoveModelT
	{
		// Token: 0x1700C314 RID: 49940
		// (get) Token: 0x0602D9EF RID: 186863 RVA: 0x0063EA55 File Offset: 0x0063CC55
		// (set) Token: 0x0602D9F0 RID: 186864 RVA: 0x0063EA5D File Offset: 0x0063CC5D
		public TSplineMoveModelUnion Config { get; set; }

		// Token: 0x0602D9F1 RID: 186865 RVA: 0x0063EA66 File Offset: 0x0063CC66
		public IEnableSplineMoveModelT()
		{
			this.Config = null;
		}
	}
}
