using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052EA RID: 21226
	public static class IGameplayDataPersistenceTetrisBoardGameVerify
	{
		// Token: 0x06022A7B RID: 141947 RVA: 0x004CDB00 File Offset: 0x004CBD00
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

		// Token: 0x02007B3D RID: 31549
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013583 RID: 79235
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
