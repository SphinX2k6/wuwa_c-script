using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C15 RID: 15381
	public static class IGraphLineTipsActorVerify
	{
		// Token: 0x06015348 RID: 86856 RVA: 0x0031240C File Offset: 0x0031060C
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

		// Token: 0x0200789D RID: 30877
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401310B RID: 78091
			public static VerifyTableAction <0>__Verify;
		}
	}
}
