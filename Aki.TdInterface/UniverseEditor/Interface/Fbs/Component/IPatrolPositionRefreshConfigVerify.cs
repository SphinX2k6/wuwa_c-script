using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D04 RID: 23812
	public static class IPatrolPositionRefreshConfigVerify
	{
		// Token: 0x060278D3 RID: 162003 RVA: 0x005694A0 File Offset: 0x005676A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPatrolPositionRefreshConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPatrolPositionRefreshConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPatrolPositionRefreshAtNearestSplinePointToPlayerVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200843D RID: 33853
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014725 RID: 83749
			public static VerifyTableAction <0>__Verify;
		}
	}
}
