using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C0B RID: 27659
	public static class IOpenInfrastructureItemDeliveryWithReturnVerify
	{
		// Token: 0x06030A29 RID: 199209 RVA: 0x0069A238 File Offset: 0x00698438
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenInfrastructureItemDeliveryWithReturnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenInfrastructureItemDeliveryWithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TInfrastructureItemDeliveryOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IOpenInfrastructureItemDeliveryWithReturnVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IOpenInfrastructureItemDeliveryWithReturnVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007DD2 RID: 32210
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013976 RID: 80246
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013977 RID: 80247
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
