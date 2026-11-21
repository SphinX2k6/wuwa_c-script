using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058AF RID: 22703
	public static class IGravityFlipTeleportConfigVerify
	{
		// Token: 0x06024D5D RID: 150877 RVA: 0x0050ECFC File Offset: 0x0050CEFC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IGravityFlipTeleportConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGravityFlipTeleportConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGravityFlipTeleportConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IGravityFlipTeleportConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083A7 RID: 33703
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014616 RID: 83478
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014617 RID: 83479
			public static VerifyTableAction <1>__Verify;
		}
	}
}
