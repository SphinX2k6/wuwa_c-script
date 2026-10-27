using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005290 RID: 21136
	public static class IFollowDecorationComponentVerify
	{
		// Token: 0x0602271F RID: 141087 RVA: 0x004C68B0 File Offset: 0x004C4AB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFollowDecorationComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFollowDecorationComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IFollowDecorationChairConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B2B RID: 31531
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013567 RID: 79207
			public static VerifyTableAction <0>__Verify;
		}
	}
}
