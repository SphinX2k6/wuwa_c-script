using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E5 RID: 22245
	public static class IPasserbyNpcSplineMoveVerify
	{
		// Token: 0x060252C5 RID: 152261 RVA: 0x00521848 File Offset: 0x0051FA48
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcSplineMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcSplineMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcSplineVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BCB RID: 31691
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013682 RID: 79490
			public static VerifyTableAction <0>__Verify;
		}
	}
}
