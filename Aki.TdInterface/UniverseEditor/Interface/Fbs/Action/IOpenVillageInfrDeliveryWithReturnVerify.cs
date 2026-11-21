using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B1 RID: 29617
	public static class IOpenVillageInfrDeliveryWithReturnVerify
	{
		// Token: 0x06033CC1 RID: 212161 RVA: 0x006FCABC File Offset: 0x006FACBC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenVillageInfrDeliveryWithReturnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenVillageInfrDeliveryWithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TVillageInfrBuildTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IOpenVillageInfrDeliveryWithReturnVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IOpenVillageInfrDeliveryWithReturnVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008669 RID: 34409
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A51 RID: 84561
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014A52 RID: 84562
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
