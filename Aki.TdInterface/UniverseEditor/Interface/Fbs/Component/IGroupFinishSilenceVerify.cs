using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DE RID: 22750
	public static class IGroupFinishSilenceVerify
	{
		// Token: 0x06024F25 RID: 151333 RVA: 0x00512824 File Offset: 0x00510A24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGroupFinishSilenceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGroupFinishSilenceVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083AF RID: 33711
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014623 RID: 83491
			public static VerifyTableAction <0>__Verify;
		}
	}
}
