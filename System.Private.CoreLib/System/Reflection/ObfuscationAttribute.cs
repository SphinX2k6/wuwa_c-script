using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000769 RID: 1897
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
	public sealed class ObfuscationAttribute : Attribute
	{
		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x060079D3 RID: 31187 RVA: 0x00121412 File Offset: 0x0011F612
		// (set) Token: 0x060079D4 RID: 31188 RVA: 0x0012141A File Offset: 0x0011F61A
		public bool StripAfterObfuscation { get; set; } = true;

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x060079D5 RID: 31189 RVA: 0x00121423 File Offset: 0x0011F623
		// (set) Token: 0x060079D6 RID: 31190 RVA: 0x0012142B File Offset: 0x0011F62B
		public bool Exclude { get; set; } = true;

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x060079D7 RID: 31191 RVA: 0x00121434 File Offset: 0x0011F634
		// (set) Token: 0x060079D8 RID: 31192 RVA: 0x0012143C File Offset: 0x0011F63C
		public bool ApplyToMembers { get; set; } = true;

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x060079D9 RID: 31193 RVA: 0x00121445 File Offset: 0x0011F645
		// (set) Token: 0x060079DA RID: 31194 RVA: 0x0012144D File Offset: 0x0011F64D
		public string Feature { get; set; } = "all";
	}
}
