using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x02004639 RID: 17977
	[NullableContext(1)]
	[Nullable(0)]
	public class IExchangeData : IBaseItemData
	{
		// Token: 0x17005B29 RID: 23337
		// (get) Token: 0x0602D31C RID: 185116 RVA: 0x00CA3670 File Offset: 0x00CA1870
		// (set) Token: 0x0602D31D RID: 185117 RVA: 0x00CA3678 File Offset: 0x00CA1878
		public int ExchangeGroupId { get; set; }

		// Token: 0x17005B2A RID: 23338
		// (get) Token: 0x0602D31E RID: 185118 RVA: 0x00CA3681 File Offset: 0x00CA1881
		// (set) Token: 0x0602D31F RID: 185119 RVA: 0x00CA3689 File Offset: 0x00CA1889
		public int LastRoleId { get; set; }

		// Token: 0x17005B2B RID: 23339
		// (get) Token: 0x0602D320 RID: 185120 RVA: 0x00CA3692 File Offset: 0x00CA1892
		// (set) Token: 0x0602D321 RID: 185121 RVA: 0x00CA369A File Offset: 0x00CA189A
		public bool IsSingleDirection { get; set; }

		// Token: 0x17005B2C RID: 23340
		// (get) Token: 0x0602D322 RID: 185122 RVA: 0x00CA36A3 File Offset: 0x00CA18A3
		// (set) Token: 0x0602D323 RID: 185123 RVA: 0x00CA36AB File Offset: 0x00CA18AB
		public int ExchangeParamId { get; set; }

		// Token: 0x17005B2D RID: 23341
		// (get) Token: 0x0602D324 RID: 185124 RVA: 0x00CA36B4 File Offset: 0x00CA18B4
		// (set) Token: 0x0602D325 RID: 185125 RVA: 0x00CA36BC File Offset: 0x00CA18BC
		public int ExchangeConsume { get; set; }

		// Token: 0x17005B2E RID: 23342
		// (get) Token: 0x0602D326 RID: 185126 RVA: 0x00CA36C5 File Offset: 0x00CA18C5
		// (set) Token: 0x0602D327 RID: 185127 RVA: 0x00CA36CD File Offset: 0x00CA18CD
		public int ExchangeTarget { get; set; }

		// Token: 0x17005B2F RID: 23343
		// (get) Token: 0x0602D328 RID: 185128 RVA: 0x00CA36D6 File Offset: 0x00CA18D6
		// (set) Token: 0x0602D329 RID: 185129 RVA: 0x00CA36DE File Offset: 0x00CA18DE
		public int ExchangeTypeId { get; set; }

		// Token: 0x17005B30 RID: 23344
		// (get) Token: 0x0602D32A RID: 185130 RVA: 0x00CA36E7 File Offset: 0x00CA18E7
		// (set) Token: 0x0602D32B RID: 185131 RVA: 0x00CA36EF File Offset: 0x00CA18EF
		public string ExchangeTypeDesc { get; set; } = "";
	}
}
