using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049F0 RID: 18928
	public static class ICheckEnterTriggerDirTypeForwardAngleVerify
	{
		// Token: 0x0601D933 RID: 121139 RVA: 0x0042998C File Offset: 0x00427B8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckEnterTriggerDirTypeForwardAngleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckEnterTriggerDirTypeForwardAngleVerify.<>O.<0>__Verify = new VerifyTableAction(IEllipseConeRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A27 RID: 31271
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133EA RID: 78826
			public static VerifyTableAction <0>__Verify;
		}
	}
}
