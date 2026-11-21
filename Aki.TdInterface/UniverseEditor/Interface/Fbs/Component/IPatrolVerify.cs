using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CF2 RID: 23794
	public static class IPatrolVerify
	{
		// Token: 0x06027845 RID: 161861 RVA: 0x00568400 File Offset: 0x00566600
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPatrolVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPatrolVerify.<>O.<0>__Verify = new VerifyTableAction(IPatrolActionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200843B RID: 33851
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014723 RID: 83747
			public static VerifyTableAction <0>__Verify;
		}
	}
}
