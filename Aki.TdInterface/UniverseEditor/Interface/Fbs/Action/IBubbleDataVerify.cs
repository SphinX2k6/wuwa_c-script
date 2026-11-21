using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A0 RID: 26784
	public static class IBubbleDataVerify
	{
		// Token: 0x0602DC9A RID: 187546 RVA: 0x0064222C File Offset: 0x0064042C
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

		// Token: 0x0200856B RID: 34155
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148FF RID: 84223
			public static VerifyTableAction <0>__Verify;
		}
	}
}
