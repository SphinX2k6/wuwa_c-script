using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064E6 RID: 25830
	public class ICommonBtAlwaysFalseDecoratorT
	{
		// Token: 0x1700BE76 RID: 48758
		// (get) Token: 0x0602BEBC RID: 179900 RVA: 0x005F8D0E File Offset: 0x005F6F0E
		// (set) Token: 0x0602BEBD RID: 179901 RVA: 0x005F8D16 File Offset: 0x005F6F16
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x0602BEBE RID: 179902 RVA: 0x005F8D1F File Offset: 0x005F6F1F
		public ICommonBtAlwaysFalseDecoratorT()
		{
			this.Type = ECommonBtDecoratorType.Condition;
		}
	}
}
