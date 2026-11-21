using System;

namespace CSharpScript.Utils
{
	// Token: 0x02003412 RID: 13330
	public enum EAstNodeType
	{
		// Token: 0x04012B0D RID: 76557
		Number,
		// Token: 0x04012B0E RID: 76558
		Boolean,
		// Token: 0x04012B0F RID: 76559
		String,
		// Token: 0x04012B10 RID: 76560
		Array,
		// Token: 0x04012B11 RID: 76561
		Identifier,
		// Token: 0x04012B12 RID: 76562
		BinaryOperator,
		// Token: 0x04012B13 RID: 76563
		UnaryOperator,
		// Token: 0x04012B14 RID: 76564
		FunctionCall,
		// Token: 0x04012B15 RID: 76565
		ParenthesizedExpression,
		// Token: 0x04012B16 RID: 76566
		Index
	}
}
