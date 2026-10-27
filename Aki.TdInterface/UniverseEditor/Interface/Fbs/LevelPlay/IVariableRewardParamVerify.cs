using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045EC RID: 17900
	public static class IVariableRewardParamVerify
	{
		// Token: 0x0601B1C8 RID: 111048 RVA: 0x003DD240 File Offset: 0x003DB440
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVariableRewardParamVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVariableRewardParamVerify.<>O.<0>__Verify = new VerifyTableAction(IVariableRewardConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079C9 RID: 31177
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013365 RID: 78693
			public static VerifyTableAction <0>__Verify;
		}
	}
}
