using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DD8 RID: 24024
	public static class IGiantStableValueRegionVerify
	{
		// Token: 0x060291F5 RID: 168437 RVA: 0x005A4CD4 File Offset: 0x005A2ED4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGiantStableValueRegionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGiantStableValueRegionVerify.<>O.<0>__Verify = new VerifyTableAction(IGiantStableValueRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CAA RID: 31914
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137D7 RID: 79831
			public static VerifyTableAction <0>__Verify;
		}
	}
}
