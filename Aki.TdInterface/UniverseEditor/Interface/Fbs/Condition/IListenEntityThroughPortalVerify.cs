using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C51 RID: 19537
	public static class IListenEntityThroughPortalVerify
	{
		// Token: 0x0601EFA8 RID: 126888 RVA: 0x00455470 File Offset: 0x00453670
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

		// Token: 0x02007A62 RID: 31330
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401342A RID: 78890
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
