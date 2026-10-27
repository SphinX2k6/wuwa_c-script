using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DDB RID: 24027
	public static class IGiantStableValueTotalVerify
	{
		// Token: 0x0602920B RID: 168459 RVA: 0x005A4F70 File Offset: 0x005A3170
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

		// Token: 0x02007CAB RID: 31915
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137D8 RID: 79832
			public static VerifyTableAction <0>__Verify;
		}
	}
}
