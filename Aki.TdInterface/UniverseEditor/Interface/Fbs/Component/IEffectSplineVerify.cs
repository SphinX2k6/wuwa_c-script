using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005116 RID: 20758
	public static class IEffectSplineVerify
	{
		// Token: 0x0602173D RID: 137021 RVA: 0x004A4F00 File Offset: 0x004A3100
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEffectSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEffectSplineVerify.<>O.<0>__Verify = new VerifyUnionAction(TEffectSplineCreateOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEffectSplineVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEffectSplineVerify.<>O.<1>__Verify = new VerifyTableAction(ICommonSplinePointVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007AEB RID: 31467
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013504 RID: 79108
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013505 RID: 79109
			public static VerifyTableAction <1>__Verify;
		}
	}
}
