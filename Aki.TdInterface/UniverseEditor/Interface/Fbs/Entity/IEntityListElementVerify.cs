using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047B0 RID: 18352
	public static class IEntityListElementVerify
	{
		// Token: 0x0601C522 RID: 116002 RVA: 0x004023E8 File Offset: 0x004005E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityListElementVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityListElementVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079F9 RID: 31225
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133A7 RID: 78759
			public static VerifyTableAction <0>__Verify;
		}
	}
}
