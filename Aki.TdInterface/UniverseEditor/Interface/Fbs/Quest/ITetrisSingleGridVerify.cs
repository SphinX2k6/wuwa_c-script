using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D1 RID: 16849
	public static class ITetrisSingleGridVerify
	{
		// Token: 0x06018D21 RID: 101665 RVA: 0x003923F1 File Offset: 0x003905F1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITetrisSingleGridVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITetrisSingleGridVerify.<>O.<0>__Verify = new VerifyTableAction(ITetrisSingleBlockVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007966 RID: 31078
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132C6 RID: 78534
			public static VerifyTableAction <0>__Verify;
		}
	}
}
