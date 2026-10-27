using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200588D RID: 22669
	public static class IRotationConfigVerify
	{
		// Token: 0x0602633D RID: 156477 RVA: 0x00544060 File Offset: 0x00542260
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRotationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRotationConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C13 RID: 31763
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136ED RID: 79597
			public static VerifyTableAction <0>__Verify;
		}
	}
}
