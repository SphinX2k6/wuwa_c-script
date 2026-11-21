using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CEC RID: 23788
	public static class IPathDrivenActorSpawnerComponentVerify
	{
		// Token: 0x060277DF RID: 161759 RVA: 0x005676E4 File Offset: 0x005658E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPathDrivenActorSpawnerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPathDrivenActorSpawnerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IIntervalSplineSpawnVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IPathDrivenActorSpawnerComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPathDrivenActorSpawnerComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200843A RID: 33850
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014721 RID: 83745
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014722 RID: 83746
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
