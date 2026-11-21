using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A5B RID: 27227
	public static class IClientModifyTargetTagVerify
	{
		// Token: 0x0602EB60 RID: 191328 RVA: 0x0065DE90 File Offset: 0x0065C090
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientModifyTargetTagVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientModifyTargetTagVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientModifyTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008596 RID: 34198
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014937 RID: 84279
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
