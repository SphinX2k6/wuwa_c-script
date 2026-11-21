using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E14 RID: 28180
	public static class IFadeInScreenVerify
	{
		// Token: 0x06030A81 RID: 199297 RVA: 0x0069ACC4 File Offset: 0x00698EC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFadeInScreenVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFadeInScreenVerify.<>O.<0>__Verify = new VerifyTableAction(IEaseDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					short typeIdVOffset = 14;
					short valueVOffset = 16;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFadeInScreenVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFadeInScreenVerify.<>O.<1>__Verify = new VerifyUnionAction(TFadeBackgroundVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020085DE RID: 34270
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014994 RID: 84372
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014995 RID: 84373
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
