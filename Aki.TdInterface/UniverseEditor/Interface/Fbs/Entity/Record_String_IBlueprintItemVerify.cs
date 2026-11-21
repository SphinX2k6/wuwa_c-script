using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C5D RID: 19549
	public static class Record_String_IBlueprintItemVerify
	{
		// Token: 0x0601DFE0 RID: 122848 RVA: 0x004345F8 File Offset: 0x004327F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = Record_String_IBlueprintItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (Record_String_IBlueprintItemVerify.<>O.<0>__Verify = new VerifyTableAction(IBlueprintItemVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200824F RID: 33359
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401441C RID: 82972
			public static VerifyTableAction <0>__Verify;
		}
	}
}
