using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F7C RID: 20348
	public static class ICheckItemsVerify
	{
		// Token: 0x0601FAFC RID: 129788 RVA: 0x00467B40 File Offset: 0x00465D40
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckItemsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckItemsVerify.<>O.<0>__Verify = new VerifyTableAction(IItemConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200828B RID: 33419
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401446D RID: 83053
			public static VerifyTableAction <0>__Verify;
		}
	}
}
