using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D6 RID: 29142
	public static class IModifyActorMaterialParamBySplineProgressVerify
	{
		// Token: 0x06032B0F RID: 207631 RVA: 0x006D9014 File Offset: 0x006D7214
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

		// Token: 0x0200862C RID: 34348
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149FD RID: 84477
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
