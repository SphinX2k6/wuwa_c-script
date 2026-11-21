using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EF9 RID: 16121
	public class ITimeDisplayParamsVarT
	{
		// Token: 0x17006D20 RID: 27936
		// (get) Token: 0x06015DD7 RID: 89559 RVA: 0x00324F5B File Offset: 0x0032315B
		// (set) Token: 0x06015DD8 RID: 89560 RVA: 0x00324F63 File Offset: 0x00323163
		public ETimeDisplayDataSource Type { get; set; }

		// Token: 0x17006D21 RID: 27937
		// (get) Token: 0x06015DD9 RID: 89561 RVA: 0x00324F6C File Offset: 0x0032316C
		// (set) Token: 0x06015DDA RID: 89562 RVA: 0x00324F74 File Offset: 0x00323174
		public TVarRefUnion Var { get; set; }

		// Token: 0x06015DDB RID: 89563 RVA: 0x00324F7D File Offset: 0x0032317D
		public ITimeDisplayParamsVarT()
		{
			this.Type = ETimeDisplayDataSource.Constant;
			this.Var = null;
		}
	}
}
