using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF7 RID: 28663
	public static class ISetGlobalTimeScaleVerify
	{
		// Token: 0x06032B3D RID: 207677 RVA: 0x006D7684 File Offset: 0x006D5884
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

		// Token: 0x02007E3B RID: 32315
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A05 RID: 80389
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
