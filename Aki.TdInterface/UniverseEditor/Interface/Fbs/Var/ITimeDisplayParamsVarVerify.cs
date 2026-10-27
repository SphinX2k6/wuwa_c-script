using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AF8 RID: 15096
	public static class ITimeDisplayParamsVarVerify
	{
		// Token: 0x06014932 RID: 84274 RVA: 0x002FED04 File Offset: 0x002FCF04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITimeDisplayParamsVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeDisplayParamsVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007882 RID: 30850
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130EA RID: 78058
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
