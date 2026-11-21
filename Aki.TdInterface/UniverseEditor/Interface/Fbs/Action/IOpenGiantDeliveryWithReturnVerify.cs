using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007363 RID: 29539
	public static class IOpenGiantDeliveryWithReturnVerify
	{
		// Token: 0x060338CB RID: 211147 RVA: 0x006F2A7C File Offset: 0x006F0C7C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenGiantDeliveryWithReturnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenGiantDeliveryWithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008659 RID: 34393
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A35 RID: 84533
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
