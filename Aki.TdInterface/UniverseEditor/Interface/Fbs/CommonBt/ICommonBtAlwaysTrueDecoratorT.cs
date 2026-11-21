using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064E9 RID: 25833
	public class ICommonBtAlwaysTrueDecoratorT
	{
		// Token: 0x1700BE79 RID: 48761
		// (get) Token: 0x0602BECE RID: 179918 RVA: 0x005F8E86 File Offset: 0x005F7086
		// (set) Token: 0x0602BECF RID: 179919 RVA: 0x005F8E8E File Offset: 0x005F708E
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x0602BED0 RID: 179920 RVA: 0x005F8E97 File Offset: 0x005F7097
		public ICommonBtAlwaysTrueDecoratorT()
		{
			this.Type = ECommonBtDecoratorType.Condition;
		}
	}
}
