using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B9A RID: 19354
	public static class ICameraTemplateVerify
	{
		// Token: 0x0601D835 RID: 120885 RVA: 0x00424C0C File Offset: 0x00422E0C
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

		// Token: 0x02008229 RID: 33321
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143EE RID: 82926
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040143EF RID: 82927
			public static VerifyTableAction <1>__Verify;
		}
	}
}
