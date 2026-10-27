using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x02005701 RID: 22273
	[NullableContext(1)]
	public interface IKurotatoAttrPreviewDelta
	{
		// Token: 0x1700882E RID: 34862
		// (get) Token: 0x06038A47 RID: 232007
		// (set) Token: 0x06038A48 RID: 232008
		int PropertyId { get; set; }

		// Token: 0x1700882F RID: 34863
		// (get) Token: 0x06038A49 RID: 232009
		// (set) Token: 0x06038A4A RID: 232010
		string ValueStr { get; set; }

		// Token: 0x17008830 RID: 34864
		// (get) Token: 0x06038A4B RID: 232011
		// (set) Token: 0x06038A4C RID: 232012
		int? LockValue { get; set; }
	}
}
