using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200736F RID: 29551
	public static class IOpenInfrastructureItemDeliveryWithReturnVerify
	{
		// Token: 0x06033949 RID: 211273 RVA: 0x006F3BCC File Offset: 0x006F1DCC
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

		// Token: 0x0200865B RID: 34395
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A37 RID: 84535
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014A38 RID: 84536
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
