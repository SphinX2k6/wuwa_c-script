using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x0200653F RID: 25919
	public static class ILevelRefDataVerify
	{
		// Token: 0x0602C2F7 RID: 180983 RVA: 0x00604710 File Offset: 0x00602910
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelRefDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelRefDataVerify.<>O.<0>__Verify = new VerifyTableAction(IStreamingGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008536 RID: 34102
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401489B RID: 84123
			public static VerifyTableAction <0>__Verify;
		}
	}
}
