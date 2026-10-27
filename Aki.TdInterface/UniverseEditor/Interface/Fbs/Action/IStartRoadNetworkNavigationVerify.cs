using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B6 RID: 29110
	public static class IStartRoadNetworkNavigationVerify
	{
		// Token: 0x060339EF RID: 211439 RVA: 0x006F3958 File Offset: 0x006F1B58
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStartRoadNetworkNavigationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStartRoadNetworkNavigationVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneItemRoadNetworkNavigationVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IStartRoadNetworkNavigationVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IStartRoadNetworkNavigationVerify.<>O.<1>__Verify = new VerifyTableAction(ISplineWayPointVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IStartRoadNetworkNavigationVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IStartRoadNetworkNavigationVerify.<>O.<1>__Verify = new VerifyTableAction(ISplineWayPointVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007E70 RID: 32368
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A50 RID: 80464
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013A51 RID: 80465
			public static VerifyTableAction <1>__Verify;
		}
	}
}
