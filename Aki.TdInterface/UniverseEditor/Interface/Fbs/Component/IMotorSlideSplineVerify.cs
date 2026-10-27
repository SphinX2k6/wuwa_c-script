using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055CE RID: 21966
	public static class IMotorSlideSplineVerify
	{
		// Token: 0x0602468A RID: 149130 RVA: 0x00506A2C File Offset: 0x00504C2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorSlideSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorSlideSplineVerify.<>O.<0>__Verify = new VerifyTableAction(IMotorSlideSplinePointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B9C RID: 31644
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013630 RID: 79408
			public static VerifyTableAction <0>__Verify;
		}
	}
}
