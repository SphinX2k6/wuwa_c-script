using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Util
{
	// Token: 0x02003B6E RID: 15214
	public static class IDiffOpVerify
	{
		// Token: 0x06014D0A RID: 85258 RVA: 0x00305DC4 File Offset: 0x00303FC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDiffOpVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDiffOpVerify.<>O.<0>__Verify = new VerifyTableAction(IDiffOpVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007889 RID: 30857
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130F2 RID: 78066
			public static VerifyTableAction <0>__Verify;
		}
	}
}
