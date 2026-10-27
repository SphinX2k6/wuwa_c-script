using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007057 RID: 28759
	public static class ISetPlayerPosVerify
	{
		// Token: 0x06032E6D RID: 208493 RVA: 0x006DDBF8 File Offset: 0x006DBDF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetPlayerPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetPlayerPosVerify.<>O.<0>__Verify = new VerifyUnionAction(TTeleportConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISetPlayerPosVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISetPlayerPosVerify.<>O.<1>__Verify = new VerifyTableAction(ITelePortAfterTimeOutVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 10;
						short valueVOffset2 = 12;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = ISetPlayerPosVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ISetPlayerPosVerify.<>O.<2>__Verify = new VerifyUnionAction(TTeleportTransitionOptionVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007E4B RID: 32331
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A16 RID: 80406
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013A17 RID: 80407
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013A18 RID: 80408
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
