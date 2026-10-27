using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048BB RID: 18619
	public static class ITwoDimensionOutlineTreeVerify
	{
		// Token: 0x0601D145 RID: 119109 RVA: 0x0041B168 File Offset: 0x00419368
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

		// Token: 0x02007A15 RID: 31253
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133D3 RID: 78803
			public static VerifyTableAction <0>__Verify;
		}
	}
}
