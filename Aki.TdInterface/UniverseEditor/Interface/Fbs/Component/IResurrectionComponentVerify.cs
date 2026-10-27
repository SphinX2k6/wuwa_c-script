using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005866 RID: 22630
	public static class IResurrectionComponentVerify
	{
		// Token: 0x060261EC RID: 156140 RVA: 0x00541928 File Offset: 0x0053FB28
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

		// Token: 0x02007C0E RID: 31758
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136E4 RID: 79588
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040136E5 RID: 79589
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040136E6 RID: 79590
			public static VerifyTableAction <2>__Verify;
		}
	}
}
