using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A8A RID: 23178
	public static class ITimePatrolSplineVerify
	{
		// Token: 0x060277AE RID: 161710 RVA: 0x0056E940 File Offset: 0x0056CB40
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimePatrolSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimePatrolSplineVerify.<>O.<0>__Verify = new VerifyTableAction(ITimePatrolSplinePointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C60 RID: 31840
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013771 RID: 79729
			public static VerifyTableAction <0>__Verify;
		}
	}
}
