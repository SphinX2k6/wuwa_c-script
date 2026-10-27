using System;

namespace CSharpScript.Utils
{
	// Token: 0x0200450F RID: 17679
	public enum ENodeType
	{
		// Token: 0x04018525 RID: 99621
		OR,
		// Token: 0x04018526 RID: 99622
		AND,
		// Token: 0x04018527 RID: 99623
		NOT,
		// Token: 0x04018528 RID: 99624
		SequenceTrue,
		// Token: 0x04018529 RID: 99625
		Equal,
		// Token: 0x0401852A RID: 99626
		NotEqual,
		// Token: 0x0401852B RID: 99627
		LessEqual,
		// Token: 0x0401852C RID: 99628
		Less,
		// Token: 0x0401852D RID: 99629
		GreaterEqual,
		// Token: 0x0401852E RID: 99630
		Greater,
		// Token: 0x0401852F RID: 99631
		FunctionCall,
		// Token: 0x04018530 RID: 99632
		MemberAccess,
		// Token: 0x04018531 RID: 99633
		Variable,
		// Token: 0x04018532 RID: 99634
		Bool,
		// Token: 0x04018533 RID: 99635
		String,
		// Token: 0x04018534 RID: 99636
		Number
	}
}
