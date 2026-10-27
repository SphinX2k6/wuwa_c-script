using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200477D RID: 18301
	public static class IBlueprintConfigVerify
	{
		// Token: 0x0601C2BC RID: 115388 RVA: 0x003FD6BD File Offset: 0x003FB8BD
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

		// Token: 0x020079EF RID: 31215
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401339C RID: 78748
			public static VerifyTableAction <0>__Verify;
		}
	}
}
