using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E38 RID: 28216
	public static class IFireBulletForwardFrontVerify
	{
		// Token: 0x06030BA9 RID: 199593 RVA: 0x0069CFF0 File Offset: 0x0069B1F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFireBulletForwardFrontVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFireBulletForwardFrontVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085E3 RID: 34275
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401499B RID: 84379
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
