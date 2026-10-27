using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061C6 RID: 25030
	public static class IAvgPlayRoleActionVerify
	{
		// Token: 0x0602B21F RID: 176671 RVA: 0x005F23F1 File Offset: 0x005F05F1
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

		// Token: 0x02007CF3 RID: 31987
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013852 RID: 79954
			public static VerifyTableAction <0>__Verify;
		}
	}
}
