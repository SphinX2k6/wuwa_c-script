using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C39 RID: 19513
	public static class IEntityPrefabElementVerify
	{
		// Token: 0x0601DE7D RID: 122493 RVA: 0x0043188C File Offset: 0x0042FA8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPrefabElementVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPrefabElementVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008246 RID: 33350
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014412 RID: 82962
			public static VerifyTableAction <0>__Verify;
		}
	}
}
