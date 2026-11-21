using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007602 RID: 30210
	public static class IResetEntityVerify
	{
		// Token: 0x06035028 RID: 217128 RVA: 0x0071F220 File Offset: 0x0071D420
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IResetEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IResetEntityVerify.<>O.<0>__Verify = new VerifyUnionAction(TResetEntityConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086A0 RID: 34464
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A93 RID: 84627
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
