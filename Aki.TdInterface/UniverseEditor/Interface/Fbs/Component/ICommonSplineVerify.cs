using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FD2 RID: 20434
	public static class ICommonSplineVerify
	{
		// Token: 0x060208B2 RID: 133298 RVA: 0x00486868 File Offset: 0x00484A68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonSplineVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonSplinePointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AB6 RID: 31414
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134A4 RID: 79012
			public static VerifyTableAction <0>__Verify;
		}
	}
}
