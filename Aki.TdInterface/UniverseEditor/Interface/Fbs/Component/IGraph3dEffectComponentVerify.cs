using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005317 RID: 21271
	public static class IGraph3dEffectComponentVerify
	{
		// Token: 0x06022C01 RID: 142337 RVA: 0x004D07B4 File Offset: 0x004CE9B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraph3dEffectComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraph3dEffectComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IFireBoxFishEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B43 RID: 31555
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401358B RID: 79243
			public static VerifyTableAction <0>__Verify;
		}
	}
}
