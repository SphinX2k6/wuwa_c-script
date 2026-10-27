using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200593D RID: 22845
	public static class ISlotShapeVerify
	{
		// Token: 0x06026A8D RID: 158349 RVA: 0x005530A4 File Offset: 0x005512A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISlotShapeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISlotShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISlotShapeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISlotShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISlotShapeVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ISlotShapeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
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

		// Token: 0x02007C31 RID: 31793
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401371A RID: 79642
			public static VerifyTableAction <0>__Verify;
		}
	}
}
