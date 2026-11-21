using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200784D RID: 30797
	public static class ISetSubScreenDataVerify
	{
		// Token: 0x06036290 RID: 221840 RVA: 0x007414C8 File Offset: 0x0073F6C8
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

		// Token: 0x020086E7 RID: 34535
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AFA RID: 84730
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014AFB RID: 84731
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014AFC RID: 84732
			public static VerifyTableAction <2>__Verify;
		}
	}
}
