using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CDA RID: 23770
	public static class IPathDrivenActorInitialSpawnConfigVerify
	{
		// Token: 0x06027768 RID: 161640 RVA: 0x005669FC File Offset: 0x00564BFC
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

		// Token: 0x02008439 RID: 33849
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014720 RID: 83744
			public static VerifyTableAction <0>__Verify;
		}
	}
}
