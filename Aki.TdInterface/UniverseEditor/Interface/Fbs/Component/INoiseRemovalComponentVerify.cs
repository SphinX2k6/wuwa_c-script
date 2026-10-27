using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005607 RID: 22023
	public static class INoiseRemovalComponentVerify
	{
		// Token: 0x060248CA RID: 149706 RVA: 0x0050B368 File Offset: 0x00509568
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INoiseRemovalComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INoiseRemovalComponentVerify.<>O.<0>__Verify = new VerifyTableAction(INoiseRemovalNodeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset = 10;
					short valueVOffset = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = INoiseRemovalComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (INoiseRemovalComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TNoiseRemovalBoarderVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BA4 RID: 31652
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401363A RID: 79418
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401363B RID: 79419
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
