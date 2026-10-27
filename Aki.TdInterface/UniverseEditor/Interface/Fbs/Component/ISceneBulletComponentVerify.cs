using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A5 RID: 22693
	public static class ISceneBulletComponentVerify
	{
		// Token: 0x06026489 RID: 156809 RVA: 0x00546FC8 File Offset: 0x005451C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneBulletComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneBulletComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneBulletGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C18 RID: 31768
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136F6 RID: 79606
			public static VerifyTableAction <0>__Verify;
		}
	}
}
