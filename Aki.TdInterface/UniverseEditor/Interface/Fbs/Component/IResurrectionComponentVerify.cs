using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E73 RID: 24179
	public static class IResurrectionComponentVerify
	{
		// Token: 0x0602874E RID: 165710 RVA: 0x00588474 File Offset: 0x00586674
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IResurrectionComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IResurrectionComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IResurrectionComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IResurrectionComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TTriggerShapeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short offsetId2 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IResurrectionComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IResurrectionComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IGravityFlipTeleportConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200847D RID: 33917
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014786 RID: 83846
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014787 RID: 83847
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04014788 RID: 83848
			public static VerifyTableAction <2>__Verify;
		}
	}
}
