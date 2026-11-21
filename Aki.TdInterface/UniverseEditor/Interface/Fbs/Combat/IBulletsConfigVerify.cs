using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02006532 RID: 25906
	public static class IBulletsConfigVerify
	{
		// Token: 0x0602C285 RID: 180869 RVA: 0x00603A35 File Offset: 0x00601C35
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBulletsConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBulletsConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IBulletConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008534 RID: 34100
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014899 RID: 84121
			public static VerifyTableAction <0>__Verify;
		}
	}
}
