using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EF6 RID: 16118
	public class ITimeDisplayParamsConstantT
	{
		// Token: 0x17006D1B RID: 27931
		// (get) Token: 0x06015DBA RID: 89530 RVA: 0x00324B00 File Offset: 0x00322D00
		// (set) Token: 0x06015DBB RID: 89531 RVA: 0x00324B08 File Offset: 0x00322D08
		public ETimeDisplayDataSource Type { get; set; }

		// Token: 0x17006D1C RID: 27932
		// (get) Token: 0x06015DBC RID: 89532 RVA: 0x00324B11 File Offset: 0x00322D11
		// (set) Token: 0x06015DBD RID: 89533 RVA: 0x00324B19 File Offset: 0x00322D19
		public int Value { get; set; }

		// Token: 0x06015DBE RID: 89534 RVA: 0x00324B22 File Offset: 0x00322D22
		public ITimeDisplayParamsConstantT()
		{
			this.Type = ETimeDisplayDataSource.Constant;
			this.Value = 0;
		}
	}
}
