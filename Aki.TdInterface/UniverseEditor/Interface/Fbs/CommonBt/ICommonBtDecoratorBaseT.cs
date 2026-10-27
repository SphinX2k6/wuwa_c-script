using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EB5 RID: 24245
	public class ICommonBtDecoratorBaseT
	{
		// Token: 0x1700B52B RID: 46379
		// (get) Token: 0x06029935 RID: 170293 RVA: 0x005B4096 File Offset: 0x005B2296
		// (set) Token: 0x06029936 RID: 170294 RVA: 0x005B409E File Offset: 0x005B229E
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x06029937 RID: 170295 RVA: 0x005B40A7 File Offset: 0x005B22A7
		public ICommonBtDecoratorBaseT()
		{
			this.Type = ECommonBtDecoratorType.Condition;
		}
	}
}
