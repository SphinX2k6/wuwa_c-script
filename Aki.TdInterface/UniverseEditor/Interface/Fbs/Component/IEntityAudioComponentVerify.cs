using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005158 RID: 20824
	public static class IEntityAudioComponentVerify
	{
		// Token: 0x060219E8 RID: 137704 RVA: 0x004AA6D4 File Offset: 0x004A88D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEntityAudioComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityAudioComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TAkEventTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AF4 RID: 31476
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013513 RID: 79123
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
