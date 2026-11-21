using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A3 RID: 17059
	public static class IFlipperSystemConfigVerify
	{
		// Token: 0x06017E0C RID: 97804 RVA: 0x0036902C File Offset: 0x0036722C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlipperSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlipperSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFlipperSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008130 RID: 33072
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014200 RID: 82432
			public static VerifyTableAction <0>__Verify;
		}
	}
}
