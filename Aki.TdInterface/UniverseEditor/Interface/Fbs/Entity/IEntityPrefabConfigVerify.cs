using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C36 RID: 19510
	public static class IEntityPrefabConfigVerify
	{
		// Token: 0x0601DE43 RID: 122435 RVA: 0x00431025 File Offset: 0x0042F225
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPrefabConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPrefabConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityPrefabVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008245 RID: 33349
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014411 RID: 82961
			public static VerifyTableAction <0>__Verify;
		}
	}
}
