using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200571A RID: 22298
	public static class IEntityStateAudioComponentVerify
	{
		// Token: 0x06023D3B RID: 146747 RVA: 0x004ECA24 File Offset: 0x004EAC24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEntityStateAudioComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityStateAudioComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TAkEventTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityStateAudioComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEntityStateAudioComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IEntityStateAudioConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200835D RID: 33629
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145A5 RID: 83365
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040145A6 RID: 83366
			public static VerifyTableAction <1>__Verify;
		}
	}
}
