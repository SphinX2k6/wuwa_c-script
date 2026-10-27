using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AEF RID: 15087
	public static class ITimeDisplayMaterialParamsVerify
	{
		// Token: 0x060148ED RID: 84205 RVA: 0x002FE500 File Offset: 0x002FC700
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITimeDisplayMaterialParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeDisplayMaterialParamsVerify.<>O.<0>__Verify = new VerifyUnionAction(TTimeDisplayParamsVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007881 RID: 30849
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130E9 RID: 78057
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
