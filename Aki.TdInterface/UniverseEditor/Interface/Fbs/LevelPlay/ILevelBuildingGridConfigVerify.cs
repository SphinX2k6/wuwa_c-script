using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044E7 RID: 17639
	public static class ILevelBuildingGridConfigVerify
	{
		// Token: 0x0601A64F RID: 108111 RVA: 0x003C4804 File Offset: 0x003C2A04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelBuildingGridConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelBuildingGridConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelBuildingGridVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079AD RID: 31149
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013339 RID: 78649
			public static VerifyTableAction <0>__Verify;
		}
	}
}
