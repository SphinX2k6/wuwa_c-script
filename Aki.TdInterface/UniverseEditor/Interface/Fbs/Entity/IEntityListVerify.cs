using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C15 RID: 19477
	public static class IEntityListVerify
	{
		// Token: 0x0601DCE1 RID: 122081 RVA: 0x0042E3F8 File Offset: 0x0042C5F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityListVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityListVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityListElementVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008241 RID: 33345
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401440D RID: 82957
			public static VerifyTableAction <0>__Verify;
		}
	}
}
