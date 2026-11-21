using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C00 RID: 19456
	public static class IEntityBundlesStateVerify
	{
		// Token: 0x0601DBCD RID: 121805 RVA: 0x0042C054 File Offset: 0x0042A254
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityBundlesStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityBundlesStateVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200823D RID: 33341
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014408 RID: 82952
			public static VerifyTableAction <0>__Verify;
		}
	}
}
