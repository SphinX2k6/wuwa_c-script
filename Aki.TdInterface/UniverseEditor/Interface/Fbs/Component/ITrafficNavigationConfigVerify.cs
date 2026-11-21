using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060D5 RID: 24789
	public static class ITrafficNavigationConfigVerify
	{
		// Token: 0x06029F60 RID: 171872 RVA: 0x005B9F98 File Offset: 0x005B8198
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrafficNavigationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrafficNavigationConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ITrafficNavigationConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrafficNavigationConfigVerify.<>O.<1>__Verify = new VerifyUnionAction(TTriggerShapeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyString(tablePos, 18, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084D8 RID: 34008
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014822 RID: 84002
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014823 RID: 84003
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
