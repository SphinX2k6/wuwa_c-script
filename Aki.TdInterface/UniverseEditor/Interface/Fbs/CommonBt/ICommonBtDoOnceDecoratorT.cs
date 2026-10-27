using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EBB RID: 24251
	public class ICommonBtDoOnceDecoratorT
	{
		// Token: 0x1700B530 RID: 46384
		// (get) Token: 0x0602995B RID: 170331 RVA: 0x005B441E File Offset: 0x005B261E
		// (set) Token: 0x0602995C RID: 170332 RVA: 0x005B4426 File Offset: 0x005B2626
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x0602995D RID: 170333 RVA: 0x005B442F File Offset: 0x005B262F
		public ICommonBtDoOnceDecoratorT()
		{
			this.Type = ECommonBtDecoratorType.Condition;
		}
	}
}
