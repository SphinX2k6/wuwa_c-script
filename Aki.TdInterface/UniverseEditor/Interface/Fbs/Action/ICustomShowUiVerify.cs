using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006518 RID: 25880
	public static class ICustomShowUiVerify
	{
		// Token: 0x0602CE4E RID: 183886 RVA: 0x0062A5F4 File Offset: 0x006287F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICustomShowUiVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICustomShowUiVerify.<>O.<0>__Verify = new VerifyTableAction(ICustomScreenTextSettingVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D38 RID: 32056
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138A8 RID: 80040
			public static VerifyTableAction <0>__Verify;
		}
	}
}
