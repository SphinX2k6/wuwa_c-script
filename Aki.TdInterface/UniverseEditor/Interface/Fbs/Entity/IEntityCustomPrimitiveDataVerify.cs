using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200479E RID: 18334
	public static class IEntityCustomPrimitiveDataVerify
	{
		// Token: 0x0601C428 RID: 115752 RVA: 0x0040031C File Offset: 0x003FE51C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityCustomPrimitiveDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityCustomPrimitiveDataVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityCustomPrimitiveData_CustomDataRowVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079F5 RID: 31221
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133A2 RID: 78754
			public static VerifyTableAction <0>__Verify;
		}
	}
}
