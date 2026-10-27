using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E4 RID: 21732
	public static class ILevelPrefabVerify
	{
		// Token: 0x06023D8F RID: 146831 RVA: 0x004F4AF4 File Offset: 0x004F2CF4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPrefabVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPrefabVerify.<>O.<0>__Verify = new VerifyTableAction(IPrefabStateConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILevelPrefabVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILevelPrefabVerify.<>O.<1>__Verify = new VerifyTableAction(IPrefabEffectConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007B80 RID: 31616
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013600 RID: 79360
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013601 RID: 79361
			public static VerifyTableAction <1>__Verify;
		}
	}
}
