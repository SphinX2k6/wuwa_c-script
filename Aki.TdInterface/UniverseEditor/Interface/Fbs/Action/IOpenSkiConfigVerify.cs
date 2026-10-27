using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C2F RID: 27695
	public static class IOpenSkiConfigVerify
	{
		// Token: 0x06030BA1 RID: 199585 RVA: 0x0069DBE0 File Offset: 0x0069BDE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenSkiConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenSkiConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DDA RID: 32218
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013981 RID: 80257
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
