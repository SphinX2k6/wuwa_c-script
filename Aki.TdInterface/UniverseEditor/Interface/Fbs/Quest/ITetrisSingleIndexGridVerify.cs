using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200462D RID: 17965
	public static class ITetrisSingleIndexGridVerify
	{
		// Token: 0x0601A48D RID: 107661 RVA: 0x003BDAB8 File Offset: 0x003BBCB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITetrisSingleIndexGridVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITetrisSingleIndexGridVerify.<>O.<0>__Verify = new VerifyTableAction(ITetrisSingleGridVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081B0 RID: 33200
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401432D RID: 82733
			public static VerifyTableAction <0>__Verify;
		}
	}
}
