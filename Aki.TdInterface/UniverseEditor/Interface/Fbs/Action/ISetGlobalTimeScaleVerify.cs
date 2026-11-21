using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C0 RID: 30656
	public static class ISetGlobalTimeScaleVerify
	{
		// Token: 0x06035DA3 RID: 220579 RVA: 0x007372C8 File Offset: 0x007354C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetGlobalTimeScaleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetGlobalTimeScaleVerify.<>O.<0>__Verify = new VerifyUnionAction(TSetGlobalTimeScaleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086D0 RID: 34512
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AD6 RID: 84694
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
