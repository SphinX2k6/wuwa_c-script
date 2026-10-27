using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EA6 RID: 24230
	public class ICommonBtAlwaysTrueDecoratorT
	{
		// Token: 0x1700B50E RID: 46350
		// (get) Token: 0x06029826 RID: 170022 RVA: 0x005AFEE2 File Offset: 0x005AE0E2
		// (set) Token: 0x06029827 RID: 170023 RVA: 0x005AFEEA File Offset: 0x005AE0EA
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x06029828 RID: 170024 RVA: 0x005AFEF3 File Offset: 0x005AE0F3
		public ICommonBtAlwaysTrueDecoratorT()
		{
			this.Type = ECommonBtDecoratorType.Condition;
		}
	}
}
