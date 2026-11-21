using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064BA RID: 25786
	public static class TCsvOutAreaBorderDataVerify
	{
		// Token: 0x0602BD75 RID: 179573 RVA: 0x005F6504 File Offset: 0x005F4704
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

		// Token: 0x02008529 RID: 34089
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401488C RID: 84108
			public static VerifyTableAction <0>__Verify;
		}
	}
}
