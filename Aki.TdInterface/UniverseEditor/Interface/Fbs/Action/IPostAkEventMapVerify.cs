using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D76 RID: 28022
	public static class IPostAkEventMapVerify
	{
		// Token: 0x060317EF RID: 202735 RVA: 0x006B5CE8 File Offset: 0x006B3EE8
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

		// Token: 0x02007E02 RID: 32258
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139BD RID: 80317
			public static VerifyTableAction <0>__Verify;
		}
	}
}
