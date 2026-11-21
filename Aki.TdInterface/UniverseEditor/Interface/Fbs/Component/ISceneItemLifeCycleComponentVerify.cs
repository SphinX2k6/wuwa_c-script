using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ED6 RID: 24278
	public static class ISceneItemLifeCycleComponentVerify
	{
		// Token: 0x06028B21 RID: 166689 RVA: 0x0058FFE4 File Offset: 0x0058E1E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneItemLifeCycleComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneItemLifeCycleComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ICreateStageConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneItemLifeCycleComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISceneItemLifeCycleComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IDestroyStageConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200848D RID: 33933
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401479F RID: 83871
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040147A0 RID: 83872
			public static VerifyTableAction <1>__Verify;
		}
	}
}
