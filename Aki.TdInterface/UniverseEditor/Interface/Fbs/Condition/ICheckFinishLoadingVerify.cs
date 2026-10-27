using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A23 RID: 18979
	public static class ICheckFinishLoadingVerify
	{
		// Token: 0x0601DB2A RID: 121642 RVA: 0x0042D7B0 File Offset: 0x0042B9B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckFinishLoadingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckFinishLoadingVerify.<>O.<0>__Verify = new VerifyTableAction(IAllPlayerTypeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A2F RID: 31279
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133F3 RID: 78835
			public static VerifyTableAction <0>__Verify;
		}
	}
}
