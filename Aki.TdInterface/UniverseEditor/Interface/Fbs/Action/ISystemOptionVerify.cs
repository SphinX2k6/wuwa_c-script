using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A5A RID: 31322
	public static class ISystemOptionVerify
	{
		// Token: 0x06037346 RID: 226118 RVA: 0x0075FB84 File Offset: 0x0075DD84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISystemOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISystemOptionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008714 RID: 34580
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B38 RID: 84792
			public static VerifyTableAction <0>__Verify;
		}
	}
}
