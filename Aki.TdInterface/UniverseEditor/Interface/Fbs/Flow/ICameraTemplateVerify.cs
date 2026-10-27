using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004732 RID: 18226
	public static class ICameraTemplateVerify
	{
		// Token: 0x0601C060 RID: 114784 RVA: 0x003F8970 File Offset: 0x003F6B70
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraTemplateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraTemplateVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 18;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICameraTemplateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICameraTemplateVerify.<>O.<1>__Verify = new VerifyTableAction(ICameraDataVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020079E0 RID: 31200
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013387 RID: 78727
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013388 RID: 78728
			public static VerifyTableAction <1>__Verify;
		}
	}
}
