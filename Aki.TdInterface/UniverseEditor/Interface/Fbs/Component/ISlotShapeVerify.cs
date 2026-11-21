using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F4A RID: 24394
	public static class ISlotShapeVerify
	{
		// Token: 0x06028FF7 RID: 167927 RVA: 0x00599D10 File Offset: 0x00597F10
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

		// Token: 0x020084A0 RID: 33952
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147BC RID: 83900
			public static VerifyTableAction <0>__Verify;
		}
	}
}
