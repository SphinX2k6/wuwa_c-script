using System;

namespace CSharpScript.Utils
{
	// Token: 0x020044F0 RID: 17648
	public enum EAstNodeType
	{
		// Token: 0x040184E5 RID: 99557
		Number,
		// Token: 0x040184E6 RID: 99558
		Boolean,
		// Token: 0x040184E7 RID: 99559
		String,
		// Token: 0x040184E8 RID: 99560
		Array,
		// Token: 0x040184E9 RID: 99561
		Identifier,
		// Token: 0x040184EA RID: 99562
		BinaryOperator,
		// Token: 0x040184EB RID: 99563
		UnaryOperator,
		// Token: 0x040184EC RID: 99564
		FunctionCall,
		// Token: 0x040184ED RID: 99565
		ParenthesizedExpression,
		// Token: 0x040184EE RID: 99566
		Index
	}
}
