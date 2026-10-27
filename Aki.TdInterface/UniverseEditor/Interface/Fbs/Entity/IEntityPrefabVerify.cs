using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047CB RID: 18379
	public static class IEntityPrefabVerify
	{
		// Token: 0x0601C656 RID: 116310 RVA: 0x004049E0 File Offset: 0x00402BE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPrefabVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPrefabVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityPrefabElementVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079FB RID: 31227
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133A9 RID: 78761
			public static VerifyTableAction <0>__Verify;
		}
	}
}
