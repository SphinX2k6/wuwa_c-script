using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051AD RID: 20909
	public static class IRoleLevelVerify
	{
		// Token: 0x06020EAC RID: 134828 RVA: 0x0048DB38 File Offset: 0x0048BD38
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

		// Token: 0x020082B9 RID: 33465
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144A0 RID: 83104
			public static VerifyTableAction <0>__Verify;
		}
	}
}
