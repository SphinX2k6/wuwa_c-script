using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AAB RID: 27307
	public static class IModifyActorMaterialParamBySplineProgressVerify
	{
		// Token: 0x0602FDAB RID: 196011 RVA: 0x006829DC File Offset: 0x00680BDC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IModifyActorMaterialParamBySplineProgressVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModifyActorMaterialParamBySplineProgressVerify.<>O.<0>__Verify = new VerifyUnionAction(TModifyActorMaterialParamBySplineProgressVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DA9 RID: 32169
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013944 RID: 80196
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
