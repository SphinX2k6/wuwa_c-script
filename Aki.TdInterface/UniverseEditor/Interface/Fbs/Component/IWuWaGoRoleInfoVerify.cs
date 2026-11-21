using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061EB RID: 25067
	public static class IWuWaGoRoleInfoVerify
	{
		// Token: 0x0602AA48 RID: 174664 RVA: 0x005D0874 File Offset: 0x005CEA74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoRoleInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoRoleInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWuWaGoRoleInfoVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IWuWaGoRoleInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084FE RID: 34046
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401485E RID: 84062
			public static VerifyTableAction <0>__Verify;
		}
	}
}
