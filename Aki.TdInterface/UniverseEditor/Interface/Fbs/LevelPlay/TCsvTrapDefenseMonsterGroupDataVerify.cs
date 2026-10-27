using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045F5 RID: 17909
	public static class TCsvTrapDefenseMonsterGroupDataVerify
	{
		// Token: 0x0601B216 RID: 111126 RVA: 0x003DDC24 File Offset: 0x003DBE24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvTrapDefenseMonsterGroupDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvTrapDefenseMonsterGroupDataVerify.<>O.<0>__Verify = new VerifyTableAction(ITrapDefenseMonsterGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079CC RID: 31180
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013368 RID: 78696
			public static VerifyTableAction <0>__Verify;
		}
	}
}
