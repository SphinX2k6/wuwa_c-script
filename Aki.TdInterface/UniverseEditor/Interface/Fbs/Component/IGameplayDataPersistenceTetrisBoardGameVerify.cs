using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200586D RID: 22637
	public static class IGameplayDataPersistenceTetrisBoardGameVerify
	{
		// Token: 0x06024B15 RID: 150293 RVA: 0x0050A62C File Offset: 0x0050882C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IGameplayDataPersistenceTetrisBoardGameVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGameplayDataPersistenceTetrisBoardGameVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200839B RID: 33691
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014607 RID: 83463
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
