using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B7 RID: 21687
	public static class IKeyRotatorConfigVerify
	{
		// Token: 0x06023BA3 RID: 146339 RVA: 0x004F08F4 File Offset: 0x004EEAF4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IKeyRotatorConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IKeyRotatorConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B79 RID: 31609
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135F3 RID: 79347
			public static VerifyTableAction <0>__Verify;
		}
	}
}
