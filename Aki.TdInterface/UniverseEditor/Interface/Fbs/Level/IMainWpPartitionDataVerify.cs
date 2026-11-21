using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200487C RID: 18556
	public static class IMainWpPartitionDataVerify
	{
		// Token: 0x0601B71A RID: 112410 RVA: 0x003E2669 File Offset: 0x003E0869
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMainWpPartitionDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMainWpPartitionDataVerify.<>O.<0>__Verify = new VerifyTableAction(ISubWpDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081DF RID: 33247
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014380 RID: 82816
			public static VerifyTableAction <0>__Verify;
		}
	}
}
