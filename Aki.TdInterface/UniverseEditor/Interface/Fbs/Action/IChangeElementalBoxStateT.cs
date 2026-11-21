using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006944 RID: 26948
	public class IChangeElementalBoxStateT
	{
		// Token: 0x1700C665 RID: 50789
		// (get) Token: 0x0602E322 RID: 189218 RVA: 0x0064F8BF File Offset: 0x0064DABF
		// (set) Token: 0x0602E323 RID: 189219 RVA: 0x0064F8C7 File Offset: 0x0064DAC7
		public TChangeElementalBoxStateTargetUnion Target { get; set; }

		// Token: 0x1700C666 RID: 50790
		// (get) Token: 0x0602E324 RID: 189220 RVA: 0x0064F8D0 File Offset: 0x0064DAD0
		// (set) Token: 0x0602E325 RID: 189221 RVA: 0x0064F8D8 File Offset: 0x0064DAD8
		public string State { get; set; }

		// Token: 0x0602E326 RID: 189222 RVA: 0x0064F8E1 File Offset: 0x0064DAE1
		public IChangeElementalBoxStateT()
		{
			this.Target = null;
			this.State = null;
		}
	}
}
