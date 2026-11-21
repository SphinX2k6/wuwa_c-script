using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D35 RID: 19765
	public static class Record_Int_IDisableEntitiesVerify
	{
		// Token: 0x0601EA52 RID: 125522 RVA: 0x00449F3C File Offset: 0x0044813C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = Record_Int_IDisableEntitiesVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (Record_Int_IDisableEntitiesVerify.<>O.<0>__Verify = new VerifyTableAction(IDisableEntitiesVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008262 RID: 33378
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014440 RID: 83008
			public static VerifyTableAction <0>__Verify;
		}
	}
}
