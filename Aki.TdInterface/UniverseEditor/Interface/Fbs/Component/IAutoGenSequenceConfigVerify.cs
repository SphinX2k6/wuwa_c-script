using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EE5 RID: 20197
	public static class IAutoGenSequenceConfigVerify
	{
		// Token: 0x0601FD66 RID: 130406 RVA: 0x0046DFF4 File Offset: 0x0046C1F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAutoGenSequenceConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAutoGenSequenceConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayLevelSequenceVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A85 RID: 31365
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013458 RID: 78936
			public static VerifyTableAction <0>__Verify;
		}
	}
}
