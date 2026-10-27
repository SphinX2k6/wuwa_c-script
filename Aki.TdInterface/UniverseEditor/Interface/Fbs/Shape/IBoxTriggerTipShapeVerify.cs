using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BFA RID: 15354
	public static class IBoxTriggerTipShapeVerify
	{
		// Token: 0x0601521E RID: 86558 RVA: 0x0030FCEC File Offset: 0x0030DEEC
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

		// Token: 0x02007898 RID: 30872
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013106 RID: 78086
			public static VerifyTableAction <0>__Verify;
		}
	}
}
