using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F5E RID: 16222
	public static class INightmareSettlementSystemConfigVerify
	{
		// Token: 0x0601712D RID: 94509 RVA: 0x00353764 File Offset: 0x00351964
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

		// Token: 0x0200790F RID: 30991
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131E5 RID: 78309
			public static VerifyTableAction <0>__Verify;
		}
	}
}
