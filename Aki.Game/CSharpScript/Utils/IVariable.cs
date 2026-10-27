using System;

namespace CSharpScript.Utils
{
	// Token: 0x0200450C RID: 17676
	public interface IVariable
	{
		// Token: 0x170073E3 RID: 29667
		// (get) Token: 0x0602D7FD RID: 186365
		// (set) Token: 0x0602D7FE RID: 186366
		EVariableType Type { get; set; }

		// Token: 0x170073E4 RID: 29668
		// (get) Token: 0x0602D7FF RID: 186367
		// (set) Token: 0x0602D800 RID: 186368
		TFormulaValue Value { get; set; }
	}
}
