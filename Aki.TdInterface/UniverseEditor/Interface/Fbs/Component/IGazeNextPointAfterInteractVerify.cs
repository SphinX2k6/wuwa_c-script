using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052F3 RID: 21235
	public static class IGazeNextPointAfterInteractVerify
	{
		// Token: 0x06022AB7 RID: 142007 RVA: 0x004CE218 File Offset: 0x004CC418
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

		// Token: 0x02007B3F RID: 31551
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013585 RID: 79237
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013586 RID: 79238
			public static VerifyTableAction <1>__Verify;
		}
	}
}
