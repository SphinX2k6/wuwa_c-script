using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007850 RID: 30800
	public static class ISetSubScreenModeVerify
	{
		// Token: 0x060362A7 RID: 221863 RVA: 0x00741870 File Offset: 0x0073FA70
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetSubScreenModeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetSubScreenModeVerify.<>O.<0>__Verify = new VerifyUnionAction(TSubScreenModeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086E8 RID: 34536
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AFD RID: 84733
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
