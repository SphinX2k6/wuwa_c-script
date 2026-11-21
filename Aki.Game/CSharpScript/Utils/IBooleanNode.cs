using System;

namespace CSharpScript.Utils
{
	// Token: 0x02003413 RID: 13331
	public interface IBooleanNode
	{
		// Token: 0x1700466A RID: 18026
		// (get) Token: 0x06021E2A RID: 138794
		// (set) Token: 0x06021E2B RID: 138795
		EAstNodeType NodeType { get; set; }

		// Token: 0x1700466B RID: 18027
		// (get) Token: 0x06021E2C RID: 138796
		// (set) Token: 0x06021E2D RID: 138797
		bool Value { get; set; }
	}
}
