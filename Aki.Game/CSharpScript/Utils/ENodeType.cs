using System;

namespace CSharpScript.Utils
{
	// Token: 0x02003431 RID: 13361
	public enum ENodeType
	{
		// Token: 0x04012B4D RID: 76621
		OR,
		// Token: 0x04012B4E RID: 76622
		AND,
		// Token: 0x04012B4F RID: 76623
		NOT,
		// Token: 0x04012B50 RID: 76624
		SequenceTrue,
		// Token: 0x04012B51 RID: 76625
		Equal,
		// Token: 0x04012B52 RID: 76626
		NotEqual,
		// Token: 0x04012B53 RID: 76627
		LessEqual,
		// Token: 0x04012B54 RID: 76628
		Less,
		// Token: 0x04012B55 RID: 76629
		GreaterEqual,
		// Token: 0x04012B56 RID: 76630
		Greater,
		// Token: 0x04012B57 RID: 76631
		FunctionCall,
		// Token: 0x04012B58 RID: 76632
		MemberAccess,
		// Token: 0x04012B59 RID: 76633
		Variable,
		// Token: 0x04012B5A RID: 76634
		Bool,
		// Token: 0x04012B5B RID: 76635
		String,
		// Token: 0x04012B5C RID: 76636
		Number
	}
}
