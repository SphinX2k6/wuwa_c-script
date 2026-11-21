using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E52 RID: 24146
	public static class IRenderFogBarrierVerify
	{
		// Token: 0x060285C6 RID: 165318 RVA: 0x00584B6C File Offset: 0x00582D6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRenderFogBarrierVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRenderFogBarrierVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRenderFogBarrierVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRenderFogBarrierVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IRenderFogBarrierVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IRenderFogBarrierVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IRenderFogBarrierVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IRenderFogBarrierVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008477 RID: 33911
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401477D RID: 83837
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401477E RID: 83838
			public static VerifyTableAction <1>__Verify;
		}
	}
}
