using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F1 RID: 29937
	public static class IPostAkEventMapVerify
	{
		// Token: 0x060347EB RID: 215019 RVA: 0x007113D0 File Offset: 0x0070F5D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPostAkEventMapVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPostAkEventMapVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayMapMusicVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200868E RID: 34446
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A81 RID: 84609
			public static VerifyTableAction <0>__Verify;
		}
	}
}
