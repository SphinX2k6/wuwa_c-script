using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E47 RID: 24135
	public static class IRenderBeforeYourEyesSceneRevealVerify
	{
		// Token: 0x06028541 RID: 165185 RVA: 0x005836F8 File Offset: 0x005818F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRenderBeforeYourEyesSceneRevealVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRenderBeforeYourEyesSceneRevealVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRenderBeforeYourEyesSceneRevealVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRenderBeforeYourEyesSceneRevealVerify.<>O.<1>__Verify = new VerifyTableAction(IRenderStateRadiusConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008474 RID: 33908
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014779 RID: 83833
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401477A RID: 83834
			public static VerifyTableAction <1>__Verify;
		}
	}
}
