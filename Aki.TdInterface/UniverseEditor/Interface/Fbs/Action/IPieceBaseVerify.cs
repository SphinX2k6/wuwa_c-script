using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007444 RID: 29764
	public static class IPieceBaseVerify
	{
		// Token: 0x06034157 RID: 213335 RVA: 0x007049C4 File Offset: 0x00702BC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPieceBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPieceBaseVerify.<>O.<0>__Verify = new VerifyTableAction(IPieceIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008677 RID: 34423
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A62 RID: 84578
			public static VerifyTableAction <0>__Verify;
		}
	}
}
