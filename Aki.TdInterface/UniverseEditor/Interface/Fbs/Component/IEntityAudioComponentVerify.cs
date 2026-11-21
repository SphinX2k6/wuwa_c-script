using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056BD RID: 22205
	public static class IEntityAudioComponentVerify
	{
		// Token: 0x0602393C RID: 145724 RVA: 0x004E4660 File Offset: 0x004E2860
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

		// Token: 0x0200834E RID: 33614
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014591 RID: 83345
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
