using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043FC RID: 17404
	public static class IProgressBarVerify
	{
		// Token: 0x06018BD6 RID: 101334 RVA: 0x00386A54 File Offset: 0x00384C54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProgressBarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProgressBarVerify.<>O.<0>__Verify = new VerifyTableAction(IProgressCalculateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008168 RID: 33128
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014271 RID: 82545
			public static VerifyTableAction <0>__Verify;
		}
	}
}
