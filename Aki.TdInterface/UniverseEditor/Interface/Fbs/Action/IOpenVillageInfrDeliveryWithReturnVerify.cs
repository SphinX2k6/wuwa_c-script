using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C4A RID: 27722
	public static class IOpenVillageInfrDeliveryWithReturnVerify
	{
		// Token: 0x06030D66 RID: 200038 RVA: 0x006A25BC File Offset: 0x006A07BC
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

		// Token: 0x02007DDF RID: 32223
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401398F RID: 80271
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013990 RID: 80272
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
