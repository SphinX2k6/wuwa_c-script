using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A60 RID: 23136
	public static class IThrowCfgVerify
	{
		// Token: 0x060275D2 RID: 161234 RVA: 0x0056ABD0 File Offset: 0x00568DD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IThrowCfgVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IThrowCfgVerify.<>O.<0>__Verify = new VerifyUnionAction(TThrowMotionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C59 RID: 31833
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013767 RID: 79719
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
