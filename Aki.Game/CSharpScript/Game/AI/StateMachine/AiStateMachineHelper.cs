using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpScript.Game.AI.StateMachine
{
	// Token: 0x02006493 RID: 25747
	public static class AiStateMachineHelper
	{
		// Token: 0x0603E8FC RID: 256252 RVA: 0x012371D4 File Offset: 0x012353D4
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
