using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EB0 RID: 20144
	public static class ICheckEnterTriggerDirTypeForwardAngleVerify
	{
		// Token: 0x0601F3A6 RID: 127910 RVA: 0x0045A5F8 File Offset: 0x004587F8
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

		// Token: 0x02008276 RID: 33398
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014457 RID: 83031
			public static VerifyTableAction <0>__Verify;
		}
	}
}
