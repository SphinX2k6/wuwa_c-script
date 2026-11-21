using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078EC RID: 30956
	public static class ISkiConfigVerify
	{
		// Token: 0x06036831 RID: 223281 RVA: 0x0074C3AC File Offset: 0x0074A5AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISkiConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISkiConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TSkiConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086F7 RID: 34551
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B12 RID: 84754
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
