using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Game.AI.StateMachine
{
	// Token: 0x02007310 RID: 29456
	public static class AiStateMachineHelper
	{
		// Token: 0x060484AF RID: 296111 RVA: 0x01294754 File Offset: 0x01292954
		[NullableContext(1)]
		public static void AppendDepthSpace(StringBuilder outBuilder, int depth)
		{
			for (int i = 0; i < depth; i++)
			{
				outBuilder.Append("    ");
			}
		}
	}
}
