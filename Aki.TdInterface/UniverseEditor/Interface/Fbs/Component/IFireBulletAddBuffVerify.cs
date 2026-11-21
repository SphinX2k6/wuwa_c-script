using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057C5 RID: 22469
	public static class IFireBulletAddBuffVerify
	{
		// Token: 0x06024466 RID: 148582 RVA: 0x004FC270 File Offset: 0x004FA470
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFireBulletAddBuffVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFireBulletAddBuffVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200837B RID: 33659
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145D7 RID: 83415
			public static VerifyTableAction <0>__Verify;
		}
	}
}
