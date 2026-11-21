using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006097 RID: 24727
	public static class ITimePatrolSplineVerify
	{
		// Token: 0x06029D26 RID: 171302 RVA: 0x005B594C File Offset: 0x005B3B4C
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

		// Token: 0x020084CF RID: 33999
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014815 RID: 83989
			public static VerifyTableAction <0>__Verify;
		}
	}
}
