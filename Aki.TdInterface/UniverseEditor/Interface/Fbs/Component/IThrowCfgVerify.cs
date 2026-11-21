using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200606D RID: 24685
	public static class IThrowCfgVerify
	{
		// Token: 0x06029B4A RID: 170826 RVA: 0x005B1BDC File Offset: 0x005AFDDC
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

		// Token: 0x020084C8 RID: 33992
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401480B RID: 83979
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
