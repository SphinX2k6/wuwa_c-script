using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060C6 RID: 24774
	public static class ITimeStopComponentVerify
	{
		// Token: 0x06029EAF RID: 171695 RVA: 0x005B88C0 File Offset: 0x005B6AC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeStopComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeStopComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ITimeStopTargetVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084D6 RID: 34006
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014820 RID: 84000
			public static VerifyTableAction <0>__Verify;
		}
	}
}
