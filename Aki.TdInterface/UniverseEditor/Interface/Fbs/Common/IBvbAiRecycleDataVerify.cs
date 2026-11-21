using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006376 RID: 25462
	public static class IBvbAiRecycleDataVerify
	{
		// Token: 0x0602B3BB RID: 177083 RVA: 0x005E5450 File Offset: 0x005E3650
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

		// Token: 0x0200850F RID: 34063
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014871 RID: 84081
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
