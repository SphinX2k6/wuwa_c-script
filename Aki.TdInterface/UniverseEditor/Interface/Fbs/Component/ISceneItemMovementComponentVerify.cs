using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058CC RID: 22732
	public static class ISceneItemMovementComponentVerify
	{
		// Token: 0x060265DD RID: 157149 RVA: 0x005498C0 File Offset: 0x00547AC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneItemMovementComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneItemMovementComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISplineMoveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneItemMovementComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISceneItemMovementComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IMovementPlatformConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C1F RID: 31775
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136FF RID: 79615
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013700 RID: 79616
			public static VerifyTableAction <1>__Verify;
		}
	}
}
