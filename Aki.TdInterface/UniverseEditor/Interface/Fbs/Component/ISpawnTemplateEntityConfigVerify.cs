using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200596A RID: 22890
	public static class ISpawnTemplateEntityConfigVerify
	{
		// Token: 0x06026C02 RID: 158722 RVA: 0x00555CBC File Offset: 0x00553EBC
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

		// Token: 0x02007C35 RID: 31797
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013721 RID: 79649
			public static VerifyTableAction <0>__Verify;
		}
	}
}
