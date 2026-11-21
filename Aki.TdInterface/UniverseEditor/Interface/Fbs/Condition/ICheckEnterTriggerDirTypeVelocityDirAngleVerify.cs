using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EB3 RID: 20147
	public static class ICheckEnterTriggerDirTypeVelocityDirAngleVerify
	{
		// Token: 0x0601F3BC RID: 127932 RVA: 0x0045A884 File Offset: 0x00458A84
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

		// Token: 0x02008277 RID: 33399
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014458 RID: 83032
			public static VerifyTableAction <0>__Verify;
		}
	}
}
