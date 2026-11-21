using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E2 RID: 29154
	public static class IModifyActorMaterialParamBySplineProgressExitSplineVerify
	{
		// Token: 0x06032B81 RID: 207745 RVA: 0x006D9FA8 File Offset: 0x006D81A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IModifyActorMaterialParamBySplineProgressExitSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModifyActorMaterialParamBySplineProgressExitSplineVerify.<>O.<0>__Verify = new VerifyUnionAction(TModifyActorMaterialParamBySplineProgressTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200862F RID: 34351
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A01 RID: 84481
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
