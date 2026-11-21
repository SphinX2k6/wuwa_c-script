using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E7F RID: 15999
	public static class IEnergyFishStateConfigVerify
	{
		// Token: 0x06015959 RID: 88409 RVA: 0x0031C6A0 File Offset: 0x0031A8A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEnergyFishStateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnergyFishStateConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TEnergyFishStateVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080BB RID: 32955
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401413A RID: 82234
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
