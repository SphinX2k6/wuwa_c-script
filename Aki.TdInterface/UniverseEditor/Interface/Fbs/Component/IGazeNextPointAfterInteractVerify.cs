using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005876 RID: 22646
	public static class IGazeNextPointAfterInteractVerify
	{
		// Token: 0x06024B51 RID: 150353 RVA: 0x0050AD44 File Offset: 0x00508F44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGazeNextPointAfterInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGazeNextPointAfterInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IGazeConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGazeNextPointAfterInteractVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IGazeNextPointAfterInteractVerify.<>O.<1>__Verify = new VerifyTableAction(IGazePerformanceVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200839D RID: 33693
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014609 RID: 83465
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401460A RID: 83466
			public static VerifyTableAction <1>__Verify;
		}
	}
}
