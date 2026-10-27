using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006704 RID: 26372
	public static class IExecBpActorFuncVerify
	{
		// Token: 0x0602DDDE RID: 187870 RVA: 0x00645A58 File Offset: 0x00643C58
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExecBpActorFuncVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExecBpActorFuncVerify.<>O.<0>__Verify = new VerifyUnionAction(TBpActorFuncTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D5B RID: 32091
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138D9 RID: 80089
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
