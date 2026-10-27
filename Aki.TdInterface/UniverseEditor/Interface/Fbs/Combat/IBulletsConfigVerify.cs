using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EEF RID: 24303
	public static class IBulletsConfigVerify
	{
		// Token: 0x06029BD1 RID: 170961 RVA: 0x005BA551 File Offset: 0x005B8751
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

		// Token: 0x02007CC3 RID: 31939
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137F3 RID: 79859
			public static VerifyTableAction <0>__Verify;
		}
	}
}
