using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066EC RID: 26348
	public static class IEntitySplineMoveTargetVerify
	{
		// Token: 0x0602DD10 RID: 187664 RVA: 0x00643FD4 File Offset: 0x006421D4
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

		// Token: 0x02007D57 RID: 32087
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138D5 RID: 80085
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
