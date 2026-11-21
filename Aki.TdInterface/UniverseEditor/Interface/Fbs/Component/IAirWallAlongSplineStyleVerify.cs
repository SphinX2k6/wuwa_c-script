using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200539F RID: 21407
	public static class IAirWallAlongSplineStyleVerify
	{
		// Token: 0x06021682 RID: 136834 RVA: 0x0049C080 File Offset: 0x0049A280
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAirWallAlongSplineStyleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAirWallAlongSplineStyleVerify.<>O.<0>__Verify = new VerifyTableAction(IAirWallCoverVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082CD RID: 33485
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144BB RID: 83131
			public static VerifyTableAction <0>__Verify;
		}
	}
}
