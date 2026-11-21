using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200494F RID: 18767
	public static class ILevelBuildingGridConfigVerify
	{
		// Token: 0x0601BE20 RID: 114208 RVA: 0x003F0A10 File Offset: 0x003EEC10
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

		// Token: 0x020081F6 RID: 33270
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143A0 RID: 82848
			public static VerifyTableAction <0>__Verify;
		}
	}
}
