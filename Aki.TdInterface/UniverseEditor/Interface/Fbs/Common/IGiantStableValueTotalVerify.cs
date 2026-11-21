using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006418 RID: 25624
	public static class IGiantStableValueTotalVerify
	{
		// Token: 0x0602B895 RID: 178325 RVA: 0x005EDCA0 File Offset: 0x005EBEA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGiantStableValueTotalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGiantStableValueTotalVerify.<>O.<0>__Verify = new VerifyTableAction(IGiantStableValueRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200851C RID: 34076
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401487E RID: 84094
			public static VerifyTableAction <0>__Verify;
		}
	}
}
