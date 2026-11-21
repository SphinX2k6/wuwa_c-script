using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004021 RID: 16417
	public static class IGraphLineTipsActorVerify
	{
		// Token: 0x0601683E RID: 92222 RVA: 0x00338F94 File Offset: 0x00337194
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraphLineTipsActorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraphLineTipsActorVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGraphLineTipsActorVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IGraphLineTipsActorVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020080E1 RID: 32993
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014167 RID: 82279
			public static VerifyTableAction <0>__Verify;
		}
	}
}
