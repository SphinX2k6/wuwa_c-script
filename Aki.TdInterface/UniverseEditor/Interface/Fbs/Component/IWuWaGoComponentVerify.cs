using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA0 RID: 23456
	public static class IWuWaGoComponentVerify
	{
		// Token: 0x060282A2 RID: 164514 RVA: 0x00585228 File Offset: 0x00583428
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IWuWaGoComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TWuWaGoEntityDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C84 RID: 31876
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137AE RID: 79790
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
