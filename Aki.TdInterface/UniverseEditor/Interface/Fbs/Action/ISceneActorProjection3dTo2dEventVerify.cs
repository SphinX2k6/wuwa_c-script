using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B3 RID: 30387
	public static class ISceneActorProjection3dTo2dEventVerify
	{
		// Token: 0x060354D8 RID: 218328 RVA: 0x007268A8 File Offset: 0x00724AA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneActorProjection3dTo2dEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneActorProjection3dTo2dEventVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneActorProjection3dTo2dEventVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISceneActorProjection3dTo2dEventVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020086AC RID: 34476
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AA0 RID: 84640
			public static VerifyTableAction <0>__Verify;
		}
	}
}
