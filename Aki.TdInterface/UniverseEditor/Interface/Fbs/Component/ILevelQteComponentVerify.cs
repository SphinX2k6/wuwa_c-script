using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054ED RID: 21741
	public static class ILevelQteComponentVerify
	{
		// Token: 0x06023DF8 RID: 146936 RVA: 0x004F5B68 File Offset: 0x004F3D68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelQteComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelQteComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISingleBtnQteVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B83 RID: 31619
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013606 RID: 79366
			public static VerifyTableAction <0>__Verify;
		}
	}
}
