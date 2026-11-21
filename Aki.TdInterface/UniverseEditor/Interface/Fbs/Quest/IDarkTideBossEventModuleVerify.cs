using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E6 RID: 16870
	public static class IDarkTideBossEventModuleVerify
	{
		// Token: 0x06017695 RID: 95893 RVA: 0x00358978 File Offset: 0x00356B78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDarkTideBossEventModuleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDarkTideBossEventModuleVerify.<>O.<0>__Verify = new VerifyUnionAction(TDarkTideBossEventVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008114 RID: 33044
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141CD RID: 82381
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
