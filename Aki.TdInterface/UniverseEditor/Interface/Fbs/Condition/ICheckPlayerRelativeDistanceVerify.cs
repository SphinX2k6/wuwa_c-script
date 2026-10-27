using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AFE RID: 19198
	public static class ICheckPlayerRelativeDistanceVerify
	{
		// Token: 0x0601E2EE RID: 123630 RVA: 0x0043B8EC File Offset: 0x00439AEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckPlayerRelativeDistanceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerRelativeDistanceVerify.<>O.<0>__Verify = new VerifyTableAction(IDistanceRangeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A44 RID: 31300
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013409 RID: 78857
			public static VerifyTableAction <0>__Verify;
		}
	}
}
