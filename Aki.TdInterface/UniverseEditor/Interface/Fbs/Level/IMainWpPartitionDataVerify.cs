using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004414 RID: 17428
	public static class IMainWpPartitionDataVerify
	{
		// Token: 0x06019F49 RID: 106313 RVA: 0x003B645D File Offset: 0x003B465D
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

		// Token: 0x02007996 RID: 31126
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013319 RID: 78617
			public static VerifyTableAction <0>__Verify;
		}
	}
}
