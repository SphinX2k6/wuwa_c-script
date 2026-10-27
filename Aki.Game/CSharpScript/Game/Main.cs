using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game
{
	// Token: 0x02004524 RID: 17700
	public class Main
	{
		// Token: 0x0602DB9F RID: 187295 RVA: 0x00A820F2 File Offset: 0x00A802F2
		[NullableContext(1)]
		public static void DoMain(UGameInstance gameInstance)
		{
			GameProcedure.Start(gameInstance);
		}
	}
}
