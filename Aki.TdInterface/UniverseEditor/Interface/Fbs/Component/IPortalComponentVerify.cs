using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200576B RID: 22379
	public static class IPortalComponentVerify
	{
		// Token: 0x06025818 RID: 153624 RVA: 0x0052C8DC File Offset: 0x0052AADC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPortalComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPortalComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TPortalConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BDF RID: 31711
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136A3 RID: 79523
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
