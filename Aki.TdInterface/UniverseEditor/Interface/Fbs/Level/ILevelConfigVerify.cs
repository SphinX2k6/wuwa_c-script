using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200440B RID: 17419
	public static class ILevelConfigVerify
	{
		// Token: 0x06019F01 RID: 106241 RVA: 0x003B5AB8 File Offset: 0x003B3CB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMainWpPartitionDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007993 RID: 31123
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013316 RID: 78614
			public static VerifyTableAction <0>__Verify;
		}
	}
}
