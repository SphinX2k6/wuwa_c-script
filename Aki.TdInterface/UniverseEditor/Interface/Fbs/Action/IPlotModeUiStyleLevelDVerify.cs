using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D9 RID: 29913
	public static class IPlotModeUiStyleLevelDVerify
	{
		// Token: 0x060346F1 RID: 214769 RVA: 0x0070F594 File Offset: 0x0070D794
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPlotModeUiStyleLevelDVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlotModeUiStyleLevelDVerify.<>O.<0>__Verify = new VerifyUnionAction(TUiStyleOfLevelDVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200868B RID: 34443
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A7E RID: 84606
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
