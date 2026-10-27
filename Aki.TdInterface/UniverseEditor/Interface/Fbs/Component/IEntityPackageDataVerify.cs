using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051A9 RID: 20905
	public static class IEntityPackageDataVerify
	{
		// Token: 0x06021D5A RID: 138586 RVA: 0x004B17F0 File Offset: 0x004AF9F0
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

		// Token: 0x02007B00 RID: 31488
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013524 RID: 79140
			public static VerifyTableAction <0>__Verify;
		}
	}
}
