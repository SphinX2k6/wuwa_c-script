using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056EB RID: 22251
	public static class IPathDrivenActorInitialSpawnConfigVerify
	{
		// Token: 0x06025301 RID: 152321 RVA: 0x00521FB0 File Offset: 0x005201B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPathDrivenActorInitialSpawnConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPathDrivenActorInitialSpawnConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPathDrivenActorInitialSpawnHandleVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BCC RID: 31692
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013683 RID: 79491
			public static VerifyTableAction <0>__Verify;
		}
	}
}
