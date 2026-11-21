using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570E RID: 22286
	public static class IEntityPackageDataVerify
	{
		// Token: 0x06023CB2 RID: 146610 RVA: 0x004EB858 File Offset: 0x004E9A58
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPackageDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPackageDataVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityPackageNodeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200835A RID: 33626
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145A2 RID: 83362
			public static VerifyTableAction <0>__Verify;
		}
	}
}
