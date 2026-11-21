using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BD7 RID: 31703
	public static class IToggleAirWallVerify
	{
		// Token: 0x06039247 RID: 234055 RVA: 0x007B8BC0 File Offset: 0x007B6DC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IToggleAirWallVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IToggleAirWallVerify.<>O.<0>__Verify = new VerifyUnionAction(TToggleAirWallVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IToggleAirWallVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IToggleAirWallVerify.<>O.<1>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200873D RID: 34621
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CBD RID: 85181
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014CBE RID: 85182
			public static VerifyTableAction <1>__Verify;
		}
	}
}
