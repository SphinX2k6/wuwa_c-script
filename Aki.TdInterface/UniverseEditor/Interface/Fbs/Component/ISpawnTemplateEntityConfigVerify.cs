using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F77 RID: 24439
	public static class ISpawnTemplateEntityConfigVerify
	{
		// Token: 0x0602916C RID: 168300 RVA: 0x0059C928 File Offset: 0x0059AB28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISpawnTemplateEntityConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpawnTemplateEntityConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISpawnTemplateEntityConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISpawnTemplateEntityConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084A4 RID: 33956
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147C3 RID: 83907
			public static VerifyTableAction <0>__Verify;
		}
	}
}
