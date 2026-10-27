using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BF7 RID: 15351
	public static class IBoxTriggerShapeVerify
	{
		// Token: 0x06015200 RID: 86528 RVA: 0x0030F84C File Offset: 0x0030DA4C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBoxTriggerShapeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBoxTriggerShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBoxTriggerShapeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBoxTriggerShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IBoxTriggerShapeVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IBoxTriggerShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
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

		// Token: 0x02007897 RID: 30871
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013105 RID: 78085
			public static VerifyTableAction <0>__Verify;
		}
	}
}
