using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E8E RID: 20110
	public static class IAirWallSpawnerComponentVerify
	{
		// Token: 0x0601FA5B RID: 129627 RVA: 0x00468574 File Offset: 0x00466774
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
			{
				short offsetId = 20;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAirWallSpawnerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAirWallSpawnerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A7B RID: 31355
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401344B RID: 78923
			public static VerifyTableAction <0>__Verify;
		}
	}
}
