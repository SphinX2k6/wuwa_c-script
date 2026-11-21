using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D9 RID: 29145
	public static class IModifyActorMaterialParamBySplineProgressConfigVerify
	{
		// Token: 0x06032B2D RID: 207661 RVA: 0x006D9404 File Offset: 0x006D7604
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IModifyActorMaterialParamBySplineProgressConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModifyActorMaterialParamBySplineProgressConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TModifyActorMaterialParamBySplineProgressTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200862D RID: 34349
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149FE RID: 84478
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
