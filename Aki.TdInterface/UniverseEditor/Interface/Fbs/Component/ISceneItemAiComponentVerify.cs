using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058AB RID: 22699
	public static class ISceneItemAiComponentVerify
	{
		// Token: 0x060264C7 RID: 156871 RVA: 0x0054785C File Offset: 0x00545A5C
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

		// Token: 0x02007C1A RID: 31770
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136F9 RID: 79609
			public static VerifyTableAction <0>__Verify;
		}
	}
}
