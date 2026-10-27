using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052C6 RID: 21190
	public static class IFoxJumpInteractPointRelationTypeVerify
	{
		// Token: 0x0602290A RID: 141578 RVA: 0x004CA7FC File Offset: 0x004C89FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFoxJumpInteractPointRelationTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFoxJumpInteractPointRelationTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFoxJumpInteractPointRelationTypeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFoxJumpInteractPointRelationTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007B34 RID: 31540
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013574 RID: 79220
			public static VerifyTableAction <0>__Verify;
		}
	}
}
