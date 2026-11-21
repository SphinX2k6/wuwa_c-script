using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C33 RID: 19507
	public static class IEntityPrefabVerify
	{
		// Token: 0x0601DE2B RID: 122411 RVA: 0x00430C7C File Offset: 0x0042EE7C
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

		// Token: 0x02008244 RID: 33348
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014410 RID: 82960
			public static VerifyTableAction <0>__Verify;
		}
	}
}
