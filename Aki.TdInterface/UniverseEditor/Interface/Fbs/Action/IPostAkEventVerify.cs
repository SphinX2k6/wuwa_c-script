using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D70 RID: 28016
	public static class IPostAkEventVerify
	{
		// Token: 0x060317BB RID: 202683 RVA: 0x006B5708 File Offset: 0x006B3908
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPostAkEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPostAkEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E01 RID: 32257
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139BC RID: 80316
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
