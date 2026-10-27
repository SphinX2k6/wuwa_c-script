using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004204 RID: 16900
	public static class ITrackLevelPlayVerify
	{
		// Token: 0x06018F4F RID: 102223 RVA: 0x0039766C File Offset: 0x0039586C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITrackLevelPlayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrackLevelPlayVerify.<>O.<0>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITrackLevelPlayVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrackLevelPlayVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITrackLevelPlayVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITrackLevelPlayVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionTrackPosVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007972 RID: 31090
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132E3 RID: 78563
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040132E4 RID: 78564
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040132E5 RID: 78565
			public static VerifyTableAction <2>__Verify;
		}
	}
}
