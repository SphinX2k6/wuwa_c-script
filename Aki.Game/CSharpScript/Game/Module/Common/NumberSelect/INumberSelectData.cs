using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.NumberSelect
{
	// Token: 0x02004B2E RID: 19246
	[NullableContext(1)]
	[Nullable(0)]
	public class INumberSelectData
	{
		// Token: 0x17006076 RID: 24694
		// (get) Token: 0x0603022E RID: 197166 RVA: 0x00D6C87F File Offset: 0x00D6AA7F
		// (set) Token: 0x0603022F RID: 197167 RVA: 0x00D6C887 File Offset: 0x00D6AA87
		public int MaxNumber { get; set; }

		// Token: 0x17006077 RID: 24695
		// (get) Token: 0x06030230 RID: 197168 RVA: 0x00D6C890 File Offset: 0x00D6AA90
		// (set) Token: 0x06030231 RID: 197169 RVA: 0x00D6C898 File Offset: 0x00D6AA98
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

		// Token: 0x17006078 RID: 24696
		// (get) Token: 0x06030232 RID: 197170 RVA: 0x00D6C8A1 File Offset: 0x00D6AAA1
		// (set) Token: 0x06030233 RID: 197171 RVA: 0x00D6C8A9 File Offset: 0x00D6AAA9
		public Action<int> ValueChangeFunction { get; set; }
	}
}
