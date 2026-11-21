using System;

namespace CSharpScript.Utils
{
	// Token: 0x0200342F RID: 13359
	public class Variable : IVariable
	{
		// Token: 0x1700469D RID: 18077
		// (get) Token: 0x06021ED1 RID: 138961 RVA: 0x009708EB File Offset: 0x0096EAEB
		// (set) Token: 0x06021ED2 RID: 138962 RVA: 0x009708F3 File Offset: 0x0096EAF3
		public EVariableType Type { get; set; }

		// Token: 0x1700469E RID: 18078
		// (get) Token: 0x06021ED3 RID: 138963 RVA: 0x009708FC File Offset: 0x0096EAFC
		// (set) Token: 0x06021ED4 RID: 138964 RVA: 0x00970904 File Offset: 0x0096EB04
		public TFormulaValue Value { get; set; }
	}
}
