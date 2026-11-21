using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005144 RID: 20804
	public static class IListenEntityThroughPortalVerify
	{
		// Token: 0x06020BAC RID: 134060 RVA: 0x00488D4C File Offset: 0x00486F4C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IListenEntityThroughPortalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IListenEntityThroughPortalVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082B4 RID: 33460
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401449A RID: 83098
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
