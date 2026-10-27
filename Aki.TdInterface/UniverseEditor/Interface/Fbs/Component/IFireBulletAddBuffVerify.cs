using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200525D RID: 21085
	public static class IFireBulletAddBuffVerify
	{
		// Token: 0x060224D0 RID: 140496 RVA: 0x004C17AC File Offset: 0x004BF9AC
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

		// Token: 0x02007B20 RID: 31520
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013557 RID: 79191
			public static VerifyTableAction <0>__Verify;
		}
	}
}
