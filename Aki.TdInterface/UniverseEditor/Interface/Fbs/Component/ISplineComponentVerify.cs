using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F8F RID: 24463
	public static class ISplineComponentVerify
	{
		// Token: 0x06029227 RID: 168487 RVA: 0x0059DF90 File Offset: 0x0059C190
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

		// Token: 0x020084A6 RID: 33958
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147C5 RID: 83909
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
