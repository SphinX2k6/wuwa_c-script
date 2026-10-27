using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004201 RID: 16897
	public static class ITrackEntityGroupVerify
	{
		// Token: 0x06018F19 RID: 102169 RVA: 0x00396D64 File Offset: 0x00394F64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITrackEntityGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrackEntityGroupVerify.<>O.<0>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 12;
					short valueVOffset2 = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ITrackEntityGroupVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrackEntityGroupVerify.<>O.<1>__Verify = new VerifyUnionAction(TTrackRuleTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007971 RID: 31089
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132E1 RID: 78561
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040132E2 RID: 78562
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
