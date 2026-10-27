using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B6 RID: 27062
	public static class IItemCellIndependentDeliverTypeVerify
	{
		// Token: 0x0602F49A RID: 193690 RVA: 0x00670CB0 File Offset: 0x0066EEB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IItemCellIndependentDeliverTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IItemCellIndependentDeliverTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IDeliverItemVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D94 RID: 32148
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013924 RID: 80164
			public static VerifyTableAction <0>__Verify;
		}
	}
}
