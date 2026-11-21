using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C7D RID: 23677
	public static class IPasserbyNpcFloorSplineVerify
	{
		// Token: 0x0602747A RID: 160890 RVA: 0x0056122C File Offset: 0x0055F42C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcFloorSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcFloorSplineVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcMoveStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200842C RID: 33836
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401470C RID: 83724
			public static VerifyTableAction <0>__Verify;
		}
	}
}
