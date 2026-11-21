using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054CE RID: 21710
	public static class IChildStateChangedConfigVerify
	{
		// Token: 0x060223FA RID: 140282 RVA: 0x004B8818 File Offset: 0x004B6A18
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChildStateChangedConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChildStateChangedConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDelayChangeStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008304 RID: 33540
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014510 RID: 83216
			public static VerifyTableAction <0>__Verify;
		}
	}
}
