using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004798 RID: 18328
	public static class IEntityBundlesStateVerify
	{
		// Token: 0x0601C3F8 RID: 115704 RVA: 0x003FFDB8 File Offset: 0x003FDFB8
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

		// Token: 0x020079F4 RID: 31220
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133A1 RID: 78753
			public static VerifyTableAction <0>__Verify;
		}
	}
}
