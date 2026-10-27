using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C9 RID: 22729
	public static class ISceneItemLifeCycleComponentVerify
	{
		// Token: 0x060265BF RID: 157119 RVA: 0x00549498 File Offset: 0x00547698
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

		// Token: 0x02007C1E RID: 31774
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136FD RID: 79613
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040136FE RID: 79614
			public static VerifyTableAction <1>__Verify;
		}
	}
}
