using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DD5 RID: 24021
	public static class IGiantStableValueRangeVerify
	{
		// Token: 0x060291DB RID: 168411 RVA: 0x005A49B4 File Offset: 0x005A2BB4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGiantStableValueRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGiantStableValueRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IGiantStableValueVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGiantStableValueRangeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IGiantStableValueRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IGiantStableValueVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007CA9 RID: 31913
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137D6 RID: 79830
			public static VerifyTableAction <0>__Verify;
		}
	}
}
