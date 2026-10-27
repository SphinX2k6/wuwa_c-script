using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B8 RID: 26552
	public static class IFireBulletForwardFrontVerify
	{
		// Token: 0x0602E363 RID: 189283 RVA: 0x0064F8AC File Offset: 0x0064DAAC
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

		// Token: 0x02007D6C RID: 32108
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138EF RID: 80111
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
