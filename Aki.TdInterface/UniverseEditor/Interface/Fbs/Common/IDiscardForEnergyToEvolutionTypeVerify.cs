using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063C7 RID: 25543
	public static class IDiscardForEnergyToEvolutionTypeVerify
	{
		// Token: 0x0602B621 RID: 177697 RVA: 0x005E9950 File Offset: 0x005E7B50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDiscardForEnergyToEvolutionTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDiscardForEnergyToEvolutionTypeVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IDiscardForEnergyToEvolutionTypeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IDiscardForEnergyToEvolutionTypeVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008513 RID: 34067
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014875 RID: 84085
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
