using System;

namespace CSharpScript.Utils
{
	// Token: 0x020044F2 RID: 17650
	public interface INumberNode
	{
		// Token: 0x170073B4 RID: 29620
		// (get) Token: 0x0602D75E RID: 186206
		// (set) Token: 0x0602D75F RID: 186207
		EAstNodeType NodeType { get; set; }

		// Token: 0x170073B5 RID: 29621
		// (get) Token: 0x0602D760 RID: 186208
		// (set) Token: 0x0602D761 RID: 186209
		TFormulaValue Value { get; set; }
	}
}
