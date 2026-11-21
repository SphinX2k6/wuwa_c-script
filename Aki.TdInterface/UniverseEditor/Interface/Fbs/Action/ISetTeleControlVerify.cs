using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007856 RID: 30806
	public static class ISetTeleControlVerify
	{
		// Token: 0x060362E2 RID: 221922 RVA: 0x0074211C File Offset: 0x0074031C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetTeleControlVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetTeleControlVerify.<>O.<0>__Verify = new VerifyUnionAction(TSetTeleControlConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086EA RID: 34538
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AFF RID: 84735
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
