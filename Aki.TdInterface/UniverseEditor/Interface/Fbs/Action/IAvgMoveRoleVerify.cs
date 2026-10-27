using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061C3 RID: 25027
	public static class IAvgMoveRoleVerify
	{
		// Token: 0x0602B207 RID: 176647 RVA: 0x005F207C File Offset: 0x005F027C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAvgMoveRoleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAvgMoveRoleVerify.<>O.<0>__Verify = new VerifyTableAction(IEaseDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CF2 RID: 31986
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013851 RID: 79953
			public static VerifyTableAction <0>__Verify;
		}
	}
}
