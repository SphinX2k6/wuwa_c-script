using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.NumberSelect
{
	// Token: 0x02005B4F RID: 23375
	[NullableContext(1)]
	[Nullable(0)]
	public class INumberSelectData
	{
		// Token: 0x17008CA4 RID: 36004
		// (get) Token: 0x0603B2E5 RID: 242405 RVA: 0x00E1C437 File Offset: 0x00E1A637
		// (set) Token: 0x0603B2E6 RID: 242406 RVA: 0x00E1C43F File Offset: 0x00E1A63F
		public int MaxNumber { get; set; }

		// Token: 0x17008CA5 RID: 36005
		// (get) Token: 0x0603B2E7 RID: 242407 RVA: 0x00E1C448 File Offset: 0x00E1A648
		// (set) Token: 0x0603B2E8 RID: 242408 RVA: 0x00E1C450 File Offset: 0x00E1A650
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<int, TableTextArgNew> GetExchangeTableText { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17008CA6 RID: 36006
		// (get) Token: 0x0603B2E9 RID: 242409 RVA: 0x00E1C459 File Offset: 0x00E1A659
		// (set) Token: 0x0603B2EA RID: 242410 RVA: 0x00E1C461 File Offset: 0x00E1A661
		public Action<int> ValueChangeFunction { get; set; }
	}
}
