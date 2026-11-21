using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E80 RID: 28288
	public static class IFlowDefineNpcGroupPerformVerify
	{
		// Token: 0x06030E11 RID: 200209 RVA: 0x006A1774 File Offset: 0x0069F974
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

		// Token: 0x020085EC RID: 34284
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149A4 RID: 84388
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
