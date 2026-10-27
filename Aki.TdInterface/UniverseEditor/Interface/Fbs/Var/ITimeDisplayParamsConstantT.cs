using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AF4 RID: 15092
	public class ITimeDisplayParamsConstantT
	{
		// Token: 0x17006780 RID: 26496
		// (get) Token: 0x06014910 RID: 84240 RVA: 0x002FE870 File Offset: 0x002FCA70
		// (set) Token: 0x06014911 RID: 84241 RVA: 0x002FE878 File Offset: 0x002FCA78
		public ETimeDisplayDataSource Type { get; set; }

		// Token: 0x17006781 RID: 26497
		// (get) Token: 0x06014912 RID: 84242 RVA: 0x002FE881 File Offset: 0x002FCA81
		// (set) Token: 0x06014913 RID: 84243 RVA: 0x002FE889 File Offset: 0x002FCA89
		public int Value { get; set; }

		// Token: 0x06014914 RID: 84244 RVA: 0x002FE892 File Offset: 0x002FCA92
		public ITimeDisplayParamsConstantT()
		{
			this.Type = ETimeDisplayDataSource.Constant;
			this.Value = 0;
		}
	}
}
