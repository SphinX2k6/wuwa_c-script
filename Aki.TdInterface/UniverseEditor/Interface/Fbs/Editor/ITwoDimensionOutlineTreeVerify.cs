using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D20 RID: 19744
	public static class ITwoDimensionOutlineTreeVerify
	{
		// Token: 0x0601E932 RID: 125234 RVA: 0x00447904 File Offset: 0x00445B04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITwoDimensionOutlineTreeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITwoDimensionOutlineTreeVerify.<>O.<0>__Verify = new VerifyTableAction(ITwoDimensionOutlineFolderNodeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200825E RID: 33374
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014439 RID: 83001
			public static VerifyTableAction <0>__Verify;
		}
	}
}
