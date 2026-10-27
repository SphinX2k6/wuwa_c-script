using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E4 RID: 22756
	public static class ISceneTextGuideUiContentVerify
	{
		// Token: 0x060266D9 RID: 157401 RVA: 0x0054BAD4 File Offset: 0x00549CD4
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

		// Token: 0x02007C24 RID: 31780
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013708 RID: 79624
			public static VerifyTableAction <0>__Verify;
		}
	}
}
