using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E77 RID: 24183
	public static class TCsvOutAreaBorderDataVerify
	{
		// Token: 0x060296CD RID: 169677 RVA: 0x005AD560 File Offset: 0x005AB760
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvOutAreaBorderDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvOutAreaBorderDataVerify.<>O.<0>__Verify = new VerifyTableAction(IOutAreaBorderTimerConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CB8 RID: 31928
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137E6 RID: 79846
			public static VerifyTableAction <0>__Verify;
		}
	}
}
