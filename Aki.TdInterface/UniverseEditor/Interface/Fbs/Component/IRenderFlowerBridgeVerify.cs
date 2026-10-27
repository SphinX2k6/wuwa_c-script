using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005845 RID: 22597
	public static class IRenderFlowerBridgeVerify
	{
		// Token: 0x06026056 RID: 155734 RVA: 0x0053DBA4 File Offset: 0x0053BDA4
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

		// Token: 0x02007C07 RID: 31751
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136DA RID: 79578
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
