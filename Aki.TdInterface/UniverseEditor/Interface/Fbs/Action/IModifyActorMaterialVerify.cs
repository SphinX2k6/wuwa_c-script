using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071CD RID: 29133
	public static class IModifyActorMaterialVerify
	{
		// Token: 0x06032AD1 RID: 207569 RVA: 0x006D8980 File Offset: 0x006D6B80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IModifyActorMaterialVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModifyActorMaterialVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					short typeIdVOffset = 6;
					short valueVOffset = 8;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IModifyActorMaterialVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IModifyActorMaterialVerify.<>O.<1>__Verify = new VerifyUnionAction(TModifyActorMaterialTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200862B RID: 34347
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149FB RID: 84475
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040149FC RID: 84476
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
