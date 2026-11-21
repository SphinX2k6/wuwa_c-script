using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054FE RID: 21758
	public static class ICircumnutationVerify
	{
		// Token: 0x060225CE RID: 140750 RVA: 0x004BC334 File Offset: 0x004BA534
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 16, false))
			{
				short offsetId = 18;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICircumnutationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICircumnutationVerify.<>O.<0>__Verify = new VerifyTableAction(IRenderTrajectoryConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008309 RID: 33545
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014519 RID: 83225
			public static VerifyTableAction <0>__Verify;
		}
	}
}
