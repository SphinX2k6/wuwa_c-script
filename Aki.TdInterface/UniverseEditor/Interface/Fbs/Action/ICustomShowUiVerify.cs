using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B86 RID: 27526
	public static class ICustomShowUiVerify
	{
		// Token: 0x0602F5E4 RID: 194020 RVA: 0x00676894 File Offset: 0x00674A94
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

		// Token: 0x020085AD RID: 34221
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014953 RID: 84307
			public static VerifyTableAction <0>__Verify;
		}
	}
}
