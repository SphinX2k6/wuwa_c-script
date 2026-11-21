using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BE5 RID: 19429
	public static class IBlueprintConfigVerify
	{
		// Token: 0x0601DA91 RID: 121489 RVA: 0x00429959 File Offset: 0x00427B59
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBlueprintConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBlueprintConfigVerify.<>O.<0>__Verify = new VerifyTableAction(Record_String_IBlueprintItemVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008238 RID: 33336
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014403 RID: 82947
			public static VerifyTableAction <0>__Verify;
		}
	}
}
