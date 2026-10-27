using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EA3 RID: 24227
	public class ICommonBtAlwaysFalseDecoratorT
	{
		// Token: 0x1700B50B RID: 46347
		// (get) Token: 0x06029814 RID: 170004 RVA: 0x005AFD6A File Offset: 0x005ADF6A
		// (set) Token: 0x06029815 RID: 170005 RVA: 0x005AFD72 File Offset: 0x005ADF72
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x06029816 RID: 170006 RVA: 0x005AFD7B File Offset: 0x005ADF7B
		public ICommonBtAlwaysFalseDecoratorT()
		{
			this.Type = ECommonBtDecoratorType.Condition;
		}
	}
}
