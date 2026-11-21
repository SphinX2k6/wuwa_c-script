using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004879 RID: 18553
	public static class ILevelsConfigVerify
	{
		// Token: 0x0601B702 RID: 112386 RVA: 0x003E234D File Offset: 0x003E054D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelsConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelsConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081DE RID: 33246
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401437F RID: 82815
			public static VerifyTableAction <0>__Verify;
		}
	}
}
