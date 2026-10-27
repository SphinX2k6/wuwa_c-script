using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D87 RID: 23943
	public static class IDiscardForEnergyToDeployTypeVerify
	{
		// Token: 0x06028F6F RID: 167791 RVA: 0x005A0474 File Offset: 0x0059E674
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDiscardForEnergyToDeployTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDiscardForEnergyToDeployTypeVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IDiscardForEnergyToDeployTypeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IDiscardForEnergyToDeployTypeVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007CA1 RID: 31905
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137CE RID: 79822
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
