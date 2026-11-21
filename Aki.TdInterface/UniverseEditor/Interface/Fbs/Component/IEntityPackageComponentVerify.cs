using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570B RID: 22283
	public static class IEntityPackageComponentVerify
	{
		// Token: 0x06023C8E RID: 146574 RVA: 0x004EB39C File Offset: 0x004E959C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPackageComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPackageComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityPackageDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008359 RID: 33625
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145A1 RID: 83361
			public static VerifyTableAction <0>__Verify;
		}
	}
}
