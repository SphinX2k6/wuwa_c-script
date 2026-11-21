using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ED9 RID: 24281
	public static class ISceneItemMovementComponentVerify
	{
		// Token: 0x06028B3F RID: 166719 RVA: 0x0059040C File Offset: 0x0058E60C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneItemMovementComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneItemMovementComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISplineMoveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneItemMovementComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISceneItemMovementComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IMovementPlatformConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200848E RID: 33934
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147A1 RID: 83873
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040147A2 RID: 83874
			public static VerifyTableAction <1>__Verify;
		}
	}
}
