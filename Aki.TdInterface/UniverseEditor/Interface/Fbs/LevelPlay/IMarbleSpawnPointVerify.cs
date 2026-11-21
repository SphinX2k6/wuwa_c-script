using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004991 RID: 18833
	public static class IMarbleSpawnPointVerify
	{
		// Token: 0x0601C1CB RID: 115147 RVA: 0x003F8FC0 File Offset: 0x003F71C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMarbleSpawnPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMarbleSpawnPointVerify.<>O.<0>__Verify = new VerifyTableAction(ITwoDimensionTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081FD RID: 33277
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143B6 RID: 82870
			public static VerifyTableAction <0>__Verify;
		}
	}
}
