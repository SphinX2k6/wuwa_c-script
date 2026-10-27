using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F05 RID: 28421
	public static class IRotatorEntityVerify
	{
		// Token: 0x06032377 RID: 205687 RVA: 0x006C8F50 File Offset: 0x006C7150
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRotatorEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRotatorEntityVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E1D RID: 32285
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139D9 RID: 80345
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
