using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02006542 RID: 25922
	public static class ILevelRefListVerify
	{
		// Token: 0x0602C30F RID: 181007 RVA: 0x00604A41 File Offset: 0x00602C41
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelRefListVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelRefListVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelRefDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008537 RID: 34103
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401489C RID: 84124
			public static VerifyTableAction <0>__Verify;
		}
	}
}
