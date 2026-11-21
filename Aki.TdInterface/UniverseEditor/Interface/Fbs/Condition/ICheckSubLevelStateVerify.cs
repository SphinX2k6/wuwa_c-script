using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005018 RID: 20504
	public static class ICheckSubLevelStateVerify
	{
		// Token: 0x06020030 RID: 131120 RVA: 0x004712B8 File Offset: 0x0046F4B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckSubLevelStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckSubLevelStateVerify.<>O.<0>__Verify = new VerifyTableAction(ICheckSubLevelStateConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200829C RID: 33436
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014480 RID: 83072
			public static VerifyTableAction <0>__Verify;
		}
	}
}
