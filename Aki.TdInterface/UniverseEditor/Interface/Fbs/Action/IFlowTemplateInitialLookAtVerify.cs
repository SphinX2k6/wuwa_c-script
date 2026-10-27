using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006827 RID: 26663
	public static class IFlowTemplateInitialLookAtVerify
	{
		// Token: 0x0602E7BE RID: 190398 RVA: 0x006580F4 File Offset: 0x006562F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFlowTemplateInitialLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowTemplateInitialLookAtVerify.<>O.<0>__Verify = new VerifyUnionAction(TActorLookAtDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D79 RID: 32121
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138FE RID: 80126
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
