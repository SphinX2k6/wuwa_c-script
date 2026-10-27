using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA8 RID: 27304
	public static class IModifyActorMaterialVerify
	{
		// Token: 0x0602FD95 RID: 195989 RVA: 0x006826C0 File Offset: 0x006808C0
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

		// Token: 0x02007DA8 RID: 32168
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013942 RID: 80194
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013943 RID: 80195
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
