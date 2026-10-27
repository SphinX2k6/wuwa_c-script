using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200449C RID: 17564
	public static class IDartThrowStrategyVerify
	{
		// Token: 0x0601A383 RID: 107395 RVA: 0x003BF168 File Offset: 0x003BD368
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 1UL, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDartThrowStrategyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDartThrowStrategyVerify.<>O.<0>__Verify = new VerifyTableAction(IDartStrategyErrorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079A5 RID: 31141
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401332F RID: 78639
			public static VerifyTableAction <0>__Verify;
		}
	}
}
