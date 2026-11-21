using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x0200652C RID: 25900
	public static class IBuffsConfigVerify
	{
		// Token: 0x0602C255 RID: 180821 RVA: 0x006034E5 File Offset: 0x006016E5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBuffsConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBuffsConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IBuffConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008533 RID: 34099
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014898 RID: 84120
			public static VerifyTableAction <0>__Verify;
		}
	}
}
