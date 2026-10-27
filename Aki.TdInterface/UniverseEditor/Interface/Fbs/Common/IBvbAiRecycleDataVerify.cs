using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D3F RID: 23871
	public static class IBvbAiRecycleDataVerify
	{
		// Token: 0x06028D51 RID: 167249 RVA: 0x0059C9E0 File Offset: 0x0059ABE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiRecycleDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiRecycleDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C9E RID: 31902
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137CB RID: 79819
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
