using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EB8 RID: 24248
	public static class ISceneItemAiComponentVerify
	{
		// Token: 0x06028A29 RID: 166441 RVA: 0x0058E3A8 File Offset: 0x0058C5A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneItemAiComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneItemAiComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneItemPatrolVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008489 RID: 33929
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401479B RID: 83867
			public static VerifyTableAction <0>__Verify;
		}
	}
}
