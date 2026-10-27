using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043CA RID: 17354
	public static class ISilentAreaExportDataVerify
	{
		// Token: 0x06019E15 RID: 106005 RVA: 0x003B42A8 File Offset: 0x003B24A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISilentAreaExportDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISilentAreaExportDataVerify.<>O.<0>__Verify = new VerifyTableAction(ISilentAreaOccupationDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007992 RID: 31122
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013315 RID: 78613
			public static VerifyTableAction <0>__Verify;
		}
	}
}
