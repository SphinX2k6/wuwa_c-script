using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064F8 RID: 25848
	public class ICommonBtDecoratorBaseT
	{
		// Token: 0x1700BE96 RID: 48790
		// (get) Token: 0x0602BFE9 RID: 180201 RVA: 0x005FD57A File Offset: 0x005FB77A
		// (set) Token: 0x0602BFEA RID: 180202 RVA: 0x005FD582 File Offset: 0x005FB782
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x0602BFEB RID: 180203 RVA: 0x005FD58B File Offset: 0x005FB78B
		public ICommonBtDecoratorBaseT()
		{
			this.Type = ECommonBtDecoratorType.Condition;
		}
	}
}
