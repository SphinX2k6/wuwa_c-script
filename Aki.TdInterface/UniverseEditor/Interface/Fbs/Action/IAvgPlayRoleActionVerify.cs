using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006834 RID: 26676
	public static class IAvgPlayRoleActionVerify
	{
		// Token: 0x0602D966 RID: 186726 RVA: 0x0063CE65 File Offset: 0x0063B065
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAvgPlayRoleActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAvgPlayRoleActionVerify.<>O.<0>__Verify = new VerifyTableAction(IAvgPlayRoleActionItemVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008565 RID: 34149
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148F9 RID: 84217
			public static VerifyTableAction <0>__Verify;
		}
	}
}
