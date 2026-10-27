using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200707B RID: 28795
	public static class ISetSportsStateVerify
	{
		// Token: 0x06032FBA RID: 208826 RVA: 0x006E07F8 File Offset: 0x006DE9F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetSportsStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetSportsStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TSportStateVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E50 RID: 32336
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A25 RID: 80421
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
