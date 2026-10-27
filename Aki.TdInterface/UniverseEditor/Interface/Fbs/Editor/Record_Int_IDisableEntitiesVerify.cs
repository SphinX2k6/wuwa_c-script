using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048D0 RID: 18640
	public static class Record_Int_IDisableEntitiesVerify
	{
		// Token: 0x0601D265 RID: 119397 RVA: 0x0041D7A0 File Offset: 0x0041B9A0
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

		// Token: 0x02007A19 RID: 31257
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133DA RID: 78810
			public static VerifyTableAction <0>__Verify;
		}
	}
}
