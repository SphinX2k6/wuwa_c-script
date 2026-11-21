using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E4F RID: 24143
	public static class IRenderFlowerBridgeVerify
	{
		// Token: 0x0602859D RID: 165277 RVA: 0x00584408 File Offset: 0x00582608
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRenderFlowerBridgeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRenderFlowerBridgeVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 12, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008476 RID: 33910
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401477C RID: 83836
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
