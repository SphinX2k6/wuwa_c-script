using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E5 RID: 21989
	public static class IDelayChangeStateVerify
	{
		// Token: 0x06022FFA RID: 143354 RVA: 0x004D0CC4 File Offset: 0x004CEEC4
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

		// Token: 0x0200832B RID: 33579
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401454E RID: 83278
			public static VerifyTableAction <0>__Verify;
		}
	}
}
