using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BEB RID: 19435
	public static class IChildEntityOwnerDataVerify
	{
		// Token: 0x0601DAE5 RID: 121573 RVA: 0x0042A324 File Offset: 0x00428524
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChildEntityOwnerDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChildEntityOwnerDataVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityOwnerEntityVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008239 RID: 33337
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014404 RID: 82948
			public static VerifyTableAction <0>__Verify;
		}
	}
}
