using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064FE RID: 25854
	public class ICommonBtDoOnceDecoratorT
	{
		// Token: 0x1700BE9B RID: 48795
		// (get) Token: 0x0602C00F RID: 180239 RVA: 0x005FD902 File Offset: 0x005FBB02
		// (set) Token: 0x0602C010 RID: 180240 RVA: 0x005FD90A File Offset: 0x005FBB0A
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x0602C011 RID: 180241 RVA: 0x005FD913 File Offset: 0x005FBB13
		public ICommonBtDoOnceDecoratorT()
		{
			this.Type = ECommonBtDecoratorType.Condition;
		}
	}
}
