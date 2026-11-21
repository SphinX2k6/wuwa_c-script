using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D6C RID: 28012
	public static class IEntitySplineMoveTargetVerify
	{
		// Token: 0x0603054D RID: 197965 RVA: 0x00691548 File Offset: 0x0068F748
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEntitySplineMoveTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntitySplineMoveTargetVerify.<>O.<0>__Verify = new VerifyUnionAction(TMoveDriveModeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085CE RID: 34254
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014981 RID: 84353
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
