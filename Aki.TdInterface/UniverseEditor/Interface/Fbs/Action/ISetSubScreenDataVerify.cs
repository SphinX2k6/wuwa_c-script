using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007081 RID: 28801
	public static class ISetSubScreenDataVerify
	{
		// Token: 0x06032FEE RID: 208878 RVA: 0x006E0EBC File Offset: 0x006DF0BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetSubScreenDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetSubScreenDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TScreenVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISetSubScreenDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISetSubScreenDataVerify.<>O.<1>__Verify = new VerifyTableAction(ISubScreenConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISetSubScreenDataVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ISetSubScreenDataVerify.<>O.<2>__Verify = new VerifyTableAction(ISubScreenTransitionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007E51 RID: 32337
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A26 RID: 80422
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013A27 RID: 80423
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013A28 RID: 80424
			public static VerifyTableAction <2>__Verify;
		}
	}
}
