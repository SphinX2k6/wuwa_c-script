using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046D8 RID: 18136
	[NullableContext(1)]
	public interface IKurotatoAttrPreviewDelta
	{
		// Token: 0x17005BF6 RID: 23542
		// (get) Token: 0x0602D957 RID: 186711
		// (set) Token: 0x0602D958 RID: 186712
		int PropertyId { get; set; }

		// Token: 0x17005BF7 RID: 23543
		// (get) Token: 0x0602D959 RID: 186713
		// (set) Token: 0x0602D95A RID: 186714
		string ValueStr { get; set; }

		// Token: 0x17005BF8 RID: 23544
		// (get) Token: 0x0602D95B RID: 186715
		// (set) Token: 0x0602D95C RID: 186716
		int? LockValue { get; set; }
	}
}
