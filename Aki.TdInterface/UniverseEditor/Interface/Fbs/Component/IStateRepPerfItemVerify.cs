using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FC5 RID: 24517
	public static class IStateRepPerfItemVerify
	{
		// Token: 0x06029410 RID: 168976 RVA: 0x005A1754 File Offset: 0x0059F954
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IStateRepPerfItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStateRepPerfItemVerify.<>O.<0>__Verify = new VerifyUnionAction(TStateRepPerfVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084AC RID: 33964
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147CD RID: 83917
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
