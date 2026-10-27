using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049F3 RID: 18931
	public static class ICheckEnterTriggerDirTypeVelocityDirAngleVerify
	{
		// Token: 0x0601D949 RID: 121161 RVA: 0x00429C18 File Offset: 0x00427E18
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckEnterTriggerDirTypeVelocityDirAngleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckEnterTriggerDirTypeVelocityDirAngleVerify.<>O.<0>__Verify = new VerifyTableAction(IEllipseConeRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A28 RID: 31272
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133EB RID: 78827
			public static VerifyTableAction <0>__Verify;
		}
	}
}
