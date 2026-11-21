using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200498E RID: 18830
	public static class IMarbleItemLevelBaseVerify
	{
		// Token: 0x0601C1AD RID: 115117 RVA: 0x003F8C20 File Offset: 0x003F6E20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMarbleItemLevelBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMarbleItemLevelBaseVerify.<>O.<0>__Verify = new VerifyTableAction(ITwoDimensionTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081FC RID: 33276
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143B5 RID: 82869
			public static VerifyTableAction <0>__Verify;
		}
	}
}
