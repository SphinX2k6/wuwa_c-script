using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCE RID: 27854
	public static class IPieceBaseVerify
	{
		// Token: 0x06031180 RID: 201088 RVA: 0x006A9790 File Offset: 0x006A7990
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

		// Token: 0x02007DEC RID: 32236
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401399F RID: 80287
			public static VerifyTableAction <0>__Verify;
		}
	}
}
