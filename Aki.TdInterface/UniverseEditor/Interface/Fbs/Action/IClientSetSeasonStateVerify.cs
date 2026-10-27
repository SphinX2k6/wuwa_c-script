using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063F0 RID: 25584
	public static class IClientSetSeasonStateVerify
	{
		// Token: 0x0602C434 RID: 181300 RVA: 0x006134C4 File Offset: 0x006116C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientSetSeasonStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientSetSeasonStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientSetSeasonStateVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D23 RID: 32035
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401388E RID: 80014
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
