using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EAD RID: 28333
	public static class IFlowTemplateInitialLookAtVerify
	{
		// Token: 0x06031046 RID: 200774 RVA: 0x006A6034 File Offset: 0x006A4234
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

		// Token: 0x020085F0 RID: 34288
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149AB RID: 84395
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
