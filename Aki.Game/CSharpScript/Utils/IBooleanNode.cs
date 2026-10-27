using System;

namespace CSharpScript.Utils
{
	// Token: 0x020044F1 RID: 17649
	public interface IBooleanNode
	{
		// Token: 0x170073B2 RID: 29618
		// (get) Token: 0x0602D75A RID: 186202
		// (set) Token: 0x0602D75B RID: 186203
		EAstNodeType NodeType { get; set; }

		// Token: 0x170073B3 RID: 29619
		// (get) Token: 0x0602D75C RID: 186204
		// (set) Token: 0x0602D75D RID: 186205
		bool Value { get; set; }
	}
}
