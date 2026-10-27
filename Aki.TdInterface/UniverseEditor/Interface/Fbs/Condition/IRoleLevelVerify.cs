using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CB4 RID: 19636
	public static class IRoleLevelVerify
	{
		// Token: 0x0601F28A RID: 127626 RVA: 0x00459FE8 File Offset: 0x004581E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRoleLevelVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRoleLevelVerify.<>O.<0>__Verify = new VerifyTableAction(ISpecifyRoleLevelVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A67 RID: 31335
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013430 RID: 78896
			public static VerifyTableAction <0>__Verify;
		}
	}
}
