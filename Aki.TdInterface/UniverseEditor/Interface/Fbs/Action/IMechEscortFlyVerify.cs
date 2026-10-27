using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A81 RID: 27265
	public static class IMechEscortFlyVerify
	{
		// Token: 0x0602FC68 RID: 195688 RVA: 0x00680430 File Offset: 0x0067E630
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMechEscortFlyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechEscortFlyVerify.<>O.<0>__Verify = new VerifyTableAction(IMechEscortPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DA4 RID: 32164
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401393D RID: 80189
			public static VerifyTableAction <0>__Verify;
		}
	}
}
