using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FE5 RID: 20453
	public static class ICheckPreloadCompleteVerify
	{
		// Token: 0x0601FE9E RID: 130718 RVA: 0x0046E854 File Offset: 0x0046CA54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckPreloadCompleteVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPreloadCompleteVerify.<>O.<0>__Verify = new VerifyTableAction(ICheckPreloadCompleteLinkResourceVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008299 RID: 33433
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401447C RID: 83068
			public static VerifyTableAction <0>__Verify;
		}
	}
}
