using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004006 RID: 16390
	public static class IBoxTriggerTipShapeVerify
	{
		// Token: 0x06016714 RID: 91924 RVA: 0x00336874 File Offset: 0x00334A74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBoxTriggerTipShapeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBoxTriggerTipShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBoxTriggerTipShapeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBoxTriggerTipShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IBoxTriggerTipShapeVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IBoxTriggerTipShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020080DC RID: 32988
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014162 RID: 82274
			public static VerifyTableAction <0>__Verify;
		}
	}
}
