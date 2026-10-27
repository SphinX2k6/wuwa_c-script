using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005080 RID: 20608
	public static class IDelayChangeStateVerify
	{
		// Token: 0x060210A6 RID: 135334 RVA: 0x00496D80 File Offset: 0x00494F80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDelayChangeStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDelayChangeStateVerify.<>O.<0>__Verify = new VerifyTableAction(IVarIntervalVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AD1 RID: 31441
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134D0 RID: 79056
			public static VerifyTableAction <0>__Verify;
		}
	}
}
