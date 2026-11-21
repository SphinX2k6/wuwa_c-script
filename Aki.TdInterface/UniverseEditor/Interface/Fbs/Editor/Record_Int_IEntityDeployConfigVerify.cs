using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D38 RID: 19768
	public static class Record_Int_IEntityDeployConfigVerify
	{
		// Token: 0x0601EA68 RID: 125544 RVA: 0x0044A1C8 File Offset: 0x004483C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = Record_Int_IEntityDeployConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (Record_Int_IEntityDeployConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDeployConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008263 RID: 33379
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014441 RID: 83009
			public static VerifyTableAction <0>__Verify;
		}
	}
}
