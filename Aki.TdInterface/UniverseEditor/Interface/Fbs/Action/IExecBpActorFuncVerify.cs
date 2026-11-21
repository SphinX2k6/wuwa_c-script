using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D84 RID: 28036
	public static class IExecBpActorFuncVerify
	{
		// Token: 0x06030621 RID: 198177 RVA: 0x00693100 File Offset: 0x00691300
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

		// Token: 0x020085D2 RID: 34258
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014985 RID: 84357
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
