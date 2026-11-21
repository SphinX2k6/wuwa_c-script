using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200583A RID: 22586
	public static class IFoxJumpPositionOnThisEntityVerify
	{
		// Token: 0x0602492C RID: 149804 RVA: 0x005066B4 File Offset: 0x005048B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFoxJumpPositionOnThisEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFoxJumpPositionOnThisEntityVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFoxJumpPositionOnThisEntityVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFoxJumpPositionOnThisEntityVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008392 RID: 33682
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145F9 RID: 83449
			public static VerifyTableAction <0>__Verify;
		}
	}
}
