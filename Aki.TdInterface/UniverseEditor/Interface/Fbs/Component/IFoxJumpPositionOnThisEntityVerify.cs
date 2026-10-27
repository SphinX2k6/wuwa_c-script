using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052CF RID: 21199
	public static class IFoxJumpPositionOnThisEntityVerify
	{
		// Token: 0x06022968 RID: 141672 RVA: 0x004CB5B8 File Offset: 0x004C97B8
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

		// Token: 0x02007B36 RID: 31542
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013578 RID: 79224
			public static VerifyTableAction <0>__Verify;
		}
	}
}
