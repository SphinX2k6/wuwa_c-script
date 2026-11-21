using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA1 RID: 23713
	public static class IPasserbyNpcOnceOnConditionMetSpawnVerify
	{
		// Token: 0x0602756A RID: 161130 RVA: 0x00562A14 File Offset: 0x00560C14
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcOnceOnConditionMetSpawnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcOnceOnConditionMetSpawnVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcRandomStandGenerateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008430 RID: 33840
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014710 RID: 83728
			public static VerifyTableAction <0>__Verify;
		}
	}
}
