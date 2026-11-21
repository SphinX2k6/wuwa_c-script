using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006792 RID: 26514
	public static class IAddGuestCharacterVerify
	{
		// Token: 0x0602CF67 RID: 184167 RVA: 0x00625438 File Offset: 0x00623638
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAddGuestCharacterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAddGuestCharacterVerify.<>O.<0>__Verify = new VerifyTableAction(IActiveRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200854D RID: 34125
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148B6 RID: 84150
			public static VerifyTableAction <0>__Verify;
		}
	}
}
