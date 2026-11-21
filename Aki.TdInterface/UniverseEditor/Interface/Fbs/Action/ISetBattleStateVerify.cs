using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007782 RID: 30594
	public static class ISetBattleStateVerify
	{
		// Token: 0x06035B33 RID: 219955 RVA: 0x00732204 File Offset: 0x00730404
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetBattleStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetBattleStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TStateOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086C7 RID: 34503
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AC1 RID: 84673
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
