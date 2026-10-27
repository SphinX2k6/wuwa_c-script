using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005329 RID: 21289
	public static class IGravityFlipTeleportConfigVerify
	{
		// Token: 0x06022CA9 RID: 142505 RVA: 0x004D1E28 File Offset: 0x004D0028
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

		// Token: 0x02007B48 RID: 31560
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013591 RID: 79249
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013592 RID: 79250
			public static VerifyTableAction <1>__Verify;
		}
	}
}
