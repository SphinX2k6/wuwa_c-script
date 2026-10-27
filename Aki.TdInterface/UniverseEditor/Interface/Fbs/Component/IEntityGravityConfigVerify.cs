using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005179 RID: 20857
	public static class IEntityGravityConfigVerify
	{
		// Token: 0x06021B78 RID: 138104 RVA: 0x004ADBEC File Offset: 0x004ABDEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEntityGravityConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityGravityConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AFA RID: 31482
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401351B RID: 79131
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
