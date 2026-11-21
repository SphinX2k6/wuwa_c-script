using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EFA RID: 16122
	public static class ITimeDisplayParamsVarVerify
	{
		// Token: 0x06015DDC RID: 89564 RVA: 0x00324F94 File Offset: 0x00323194
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITimeDisplayParamsVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeDisplayParamsVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080C5 RID: 32965
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014145 RID: 82245
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
