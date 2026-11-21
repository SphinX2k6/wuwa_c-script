using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA5 RID: 23461
	public static class INoiseRemovalComponentVerify
	{
		// Token: 0x06026ADA RID: 158426 RVA: 0x0054B980 File Offset: 0x00549B80
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

		// Token: 0x02008406 RID: 33798
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146C9 RID: 83657
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146CA RID: 83658
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
