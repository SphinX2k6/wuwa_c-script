using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C3C RID: 19516
	public static class IEntityStateVerify
	{
		// Token: 0x0601DE93 RID: 122515 RVA: 0x00431B48 File Offset: 0x0042FD48
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityStateVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008247 RID: 33351
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014413 RID: 82963
			public static VerifyTableAction <0>__Verify;
		}
	}
}
