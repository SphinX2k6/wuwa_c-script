using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200699F RID: 27039
	public static class IChangeTimerVerify
	{
		// Token: 0x0602E629 RID: 189993 RVA: 0x00654BEC File Offset: 0x00652DEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IChangeTimerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeTimerVerify.<>O.<0>__Verify = new VerifyUnionAction(TChangeTimerVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008585 RID: 34181
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401491F RID: 84255
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
