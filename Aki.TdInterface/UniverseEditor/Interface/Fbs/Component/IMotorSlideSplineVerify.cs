using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B6C RID: 23404
	public static class IMotorSlideSplineVerify
	{
		// Token: 0x06026897 RID: 157847 RVA: 0x00546FA4 File Offset: 0x005451A4
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

		// Token: 0x020083FE RID: 33790
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146BF RID: 83647
			public static VerifyTableAction <0>__Verify;
		}
	}
}
