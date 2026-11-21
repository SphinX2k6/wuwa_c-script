using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005630 RID: 22064
	public static class IDurabilityStateConfigVerify
	{
		// Token: 0x060233B0 RID: 144304 RVA: 0x004D9220 File Offset: 0x004D7420
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDurabilityStateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDurabilityStateConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDurabilityStateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200833A RID: 33594
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401456F RID: 83311
			public static VerifyTableAction <0>__Verify;
		}
	}
}
