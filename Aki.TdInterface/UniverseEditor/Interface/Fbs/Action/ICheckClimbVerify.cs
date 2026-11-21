using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CB RID: 27083
	public static class ICheckClimbVerify
	{
		// Token: 0x0602E766 RID: 190310 RVA: 0x00656E08 File Offset: 0x00655008
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckClimbVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckClimbVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008589 RID: 34185
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014924 RID: 84260
			public static VerifyTableAction <0>__Verify;
		}
	}
}
