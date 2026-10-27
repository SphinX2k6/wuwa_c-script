using System;

namespace CSharpScript.Utils
{
	// Token: 0x0200450D RID: 17677
	public class Variable : IVariable
	{
		// Token: 0x170073E5 RID: 29669
		// (get) Token: 0x0602D801 RID: 186369 RVA: 0x00A44ADB File Offset: 0x00A42CDB
		// (set) Token: 0x0602D802 RID: 186370 RVA: 0x00A44AE3 File Offset: 0x00A42CE3
		public EVariableType Type { get; set; }

		// Token: 0x170073E6 RID: 29670
		// (get) Token: 0x0602D803 RID: 186371 RVA: 0x00A44AEC File Offset: 0x00A42CEC
		// (set) Token: 0x0602D804 RID: 186372 RVA: 0x00A44AF4 File Offset: 0x00A42CF4
		public TFormulaValue Value { get; set; }
	}
}
