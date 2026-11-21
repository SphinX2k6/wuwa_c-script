using System;

namespace CSharpScript.Utils
{
	// Token: 0x02003414 RID: 13332
	public interface INumberNode
	{
		// Token: 0x1700466C RID: 18028
		// (get) Token: 0x06021E2E RID: 138798
		// (set) Token: 0x06021E2F RID: 138799
		EAstNodeType NodeType { get; set; }

		// Token: 0x1700466D RID: 18029
		// (get) Token: 0x06021E30 RID: 138800
		// (set) Token: 0x06021E31 RID: 138801
		TFormulaValue Value { get; set; }
	}
}
