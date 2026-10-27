using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006800 RID: 26624
	public static class IFlowDefineNpcGroupPerformVerify
	{
		// Token: 0x0602E5CB RID: 189899 RVA: 0x00654030 File Offset: 0x00652230
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFlowDefineNpcGroupPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowDefineNpcGroupPerformVerify.<>O.<0>__Verify = new VerifyUnionAction(TFlowDefineNpcGroupPerformTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D75 RID: 32117
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138F8 RID: 80120
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
