using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BAE RID: 27566
	public static class INotifyMonsterPerceptionVerify
	{
		// Token: 0x060306C8 RID: 198344 RVA: 0x006938E4 File Offset: 0x00691AE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INotifyMonsterPerceptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INotifyMonsterPerceptionVerify.<>O.<0>__Verify = new VerifyUnionAction(TBattleStatePerceptionBehaviorVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DC5 RID: 32197
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013969 RID: 80233
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
