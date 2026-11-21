using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004003 RID: 16387
	public static class IBoxTriggerShapeVerify
	{
		// Token: 0x060166F6 RID: 91894 RVA: 0x003363D4 File Offset: 0x003345D4
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

		// Token: 0x020080DB RID: 32987
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014161 RID: 82273
			public static VerifyTableAction <0>__Verify;
		}
	}
}
