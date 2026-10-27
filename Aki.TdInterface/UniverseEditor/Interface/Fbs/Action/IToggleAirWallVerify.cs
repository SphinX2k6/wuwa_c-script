using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073ED RID: 29677
	public static class IToggleAirWallVerify
	{
		// Token: 0x06035E94 RID: 220820 RVA: 0x0075644C File Offset: 0x0075464C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IToggleAirWallVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IToggleAirWallVerify.<>O.<0>__Verify = new VerifyUnionAction(TToggleAirWallVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IToggleAirWallVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IToggleAirWallVerify.<>O.<1>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007EA4 RID: 32420
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BE4 RID: 80868
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013BE5 RID: 80869
			public static VerifyTableAction <1>__Verify;
		}
	}
}
