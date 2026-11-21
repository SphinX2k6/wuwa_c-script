using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006995 RID: 27029
	public class IChangeStateT
	{
		// Token: 0x1700C6FC RID: 50940
		// (get) Token: 0x0602E5D4 RID: 189908 RVA: 0x0065419A File Offset: 0x0065239A
		// (set) Token: 0x0602E5D5 RID: 189909 RVA: 0x006541A2 File Offset: 0x006523A2
		public int StateId { get; set; }

		// Token: 0x0602E5D6 RID: 189910 RVA: 0x006541AB File Offset: 0x006523AB
		public IChangeStateT()
		{
			this.StateId = 0;
		}
	}
}
