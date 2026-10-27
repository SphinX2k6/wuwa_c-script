using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005982 RID: 22914
	public static class ISplineComponentVerify
	{
		// Token: 0x06026CBD RID: 158909 RVA: 0x00557324 File Offset: 0x00555524
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISplineComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISplineComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TSplineOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C37 RID: 31799
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013723 RID: 79651
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
