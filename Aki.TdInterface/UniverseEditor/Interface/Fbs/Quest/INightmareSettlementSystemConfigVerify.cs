using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200439C RID: 17308
	public static class INightmareSettlementSystemConfigVerify
	{
		// Token: 0x0601878F RID: 100239 RVA: 0x0037CBD8 File Offset: 0x0037ADD8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INightmareSettlementSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INightmareSettlementSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(INightmareSettlementSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008155 RID: 33109
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014245 RID: 82501
			public static VerifyTableAction <0>__Verify;
		}
	}
}
