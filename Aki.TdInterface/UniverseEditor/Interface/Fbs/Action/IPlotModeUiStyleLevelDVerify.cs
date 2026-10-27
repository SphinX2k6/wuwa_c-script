using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D5E RID: 27998
	public static class IPlotModeUiStyleLevelDVerify
	{
		// Token: 0x060316F5 RID: 202485 RVA: 0x006B3EAC File Offset: 0x006B20AC
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

		// Token: 0x02007DFF RID: 32255
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139BA RID: 80314
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
