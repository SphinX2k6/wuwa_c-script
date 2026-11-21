using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EF1 RID: 24305
	public static class ISceneTextGuideUiContentVerify
	{
		// Token: 0x06028C3B RID: 166971 RVA: 0x00592620 File Offset: 0x00590820
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneTextGuideUiContentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneTextGuideUiContentVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneTextGuideUiActionMappingIconVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008493 RID: 33939
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147AA RID: 83882
			public static VerifyTableAction <0>__Verify;
		}
	}
}
