using System;

namespace CSharpScript.Utils
{
	// Token: 0x0200342E RID: 13358
	public interface IVariable
	{
		// Token: 0x1700469B RID: 18075
		// (get) Token: 0x06021ECD RID: 138957
		// (set) Token: 0x06021ECE RID: 138958
		EVariableType Type { get; set; }

		// Token: 0x1700469C RID: 18076
		// (get) Token: 0x06021ECF RID: 138959
		// (set) Token: 0x06021ED0 RID: 138960
		TFormulaValue Value { get; set; }
	}
}
