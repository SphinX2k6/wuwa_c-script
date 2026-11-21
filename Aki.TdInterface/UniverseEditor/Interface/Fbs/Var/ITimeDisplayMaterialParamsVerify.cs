using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EF1 RID: 16113
	public static class ITimeDisplayMaterialParamsVerify
	{
		// Token: 0x06015D97 RID: 89495 RVA: 0x00324790 File Offset: 0x00322990
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITimeDisplayMaterialParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeDisplayMaterialParamsVerify.<>O.<0>__Verify = new VerifyUnionAction(TTimeDisplayParamsVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080C4 RID: 32964
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014144 RID: 82244
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
