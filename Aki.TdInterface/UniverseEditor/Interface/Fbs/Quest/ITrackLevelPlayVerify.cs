using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004660 RID: 18016
	public static class ITrackLevelPlayVerify
	{
		// Token: 0x0601A6BB RID: 108219 RVA: 0x003C2D44 File Offset: 0x003C0F44
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

		// Token: 0x020081BB RID: 33211
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401434A RID: 82762
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401434B RID: 82763
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401434C RID: 82764
			public static VerifyTableAction <2>__Verify;
		}
	}
}
