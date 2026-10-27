using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C33 RID: 15411
	public static class IRelativeTipActorTransformVerify
	{
		// Token: 0x06015466 RID: 87142 RVA: 0x0031455C File Offset: 0x0031275C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRelativeTipActorTransformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRelativeTipActorTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRelativeTipActorTransformVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IRelativeTipActorTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078A1 RID: 30881
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401310F RID: 78095
			public static VerifyTableAction <0>__Verify;
		}
	}
}
