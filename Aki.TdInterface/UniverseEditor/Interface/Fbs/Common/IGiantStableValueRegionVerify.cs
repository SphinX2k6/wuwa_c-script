using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006415 RID: 25621
	public static class IGiantStableValueRegionVerify
	{
		// Token: 0x0602B87F RID: 178303 RVA: 0x005EDA04 File Offset: 0x005EBC04
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

		// Token: 0x0200851B RID: 34075
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401487D RID: 84093
			public static VerifyTableAction <0>__Verify;
		}
	}
}
