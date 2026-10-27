using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047F5 RID: 18421
	public static class Record_String_IBlueprintItemVerify
	{
		// Token: 0x0601C7E3 RID: 116707 RVA: 0x00407CA8 File Offset: 0x00405EA8
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

		// Token: 0x02007A06 RID: 31238
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133B5 RID: 78773
			public static VerifyTableAction <0>__Verify;
		}
	}
}
