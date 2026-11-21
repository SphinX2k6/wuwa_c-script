using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A0F RID: 18959
	public static class IRollBlockPathVerify
	{
		// Token: 0x0601C723 RID: 116515 RVA: 0x004047E4 File Offset: 0x004029E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRollBlockPathVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockPathVerify.<>O.<0>__Verify = new VerifyTableAction(IRollBlockPathNodeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200820D RID: 33293
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143C6 RID: 82886
			public static VerifyTableAction <0>__Verify;
		}
	}
}
