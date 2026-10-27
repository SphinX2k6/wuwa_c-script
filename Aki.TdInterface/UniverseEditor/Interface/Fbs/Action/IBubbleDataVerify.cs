using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200622F RID: 25135
	public static class IBubbleDataVerify
	{
		// Token: 0x0602B539 RID: 177465 RVA: 0x005F7424 File Offset: 0x005F5624
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBubbleDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBubbleDataVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CF8 RID: 31992
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013857 RID: 79959
			public static VerifyTableAction <0>__Verify;
		}
	}
}
