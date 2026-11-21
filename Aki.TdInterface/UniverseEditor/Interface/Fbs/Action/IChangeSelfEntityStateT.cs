using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006992 RID: 27026
	public class IChangeSelfEntityStateT
	{
		// Token: 0x1700C6F9 RID: 50937
		// (get) Token: 0x0602E5C2 RID: 189890 RVA: 0x00654029 File Offset: 0x00652229
		// (set) Token: 0x0602E5C3 RID: 189891 RVA: 0x00654031 File Offset: 0x00652231
		public string EntityState { get; set; }

		// Token: 0x0602E5C4 RID: 189892 RVA: 0x0065403A File Offset: 0x0065223A
		public IChangeSelfEntityStateT()
		{
			this.EntityState = null;
		}
	}
}
