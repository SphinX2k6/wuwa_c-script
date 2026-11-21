using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A54 RID: 19028
	public static class IVariableRewardParamVerify
	{
		// Token: 0x0601C99D RID: 117149 RVA: 0x004094DC File Offset: 0x004076DC
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

		// Token: 0x02008212 RID: 33298
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143CC RID: 82892
			public static VerifyTableAction <0>__Verify;
		}
	}
}
