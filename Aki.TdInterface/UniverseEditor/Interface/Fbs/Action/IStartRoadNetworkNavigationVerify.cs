using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200798B RID: 31115
	public static class IStartRoadNetworkNavigationVerify
	{
		// Token: 0x06036CED RID: 224493 RVA: 0x00754C24 File Offset: 0x00752E24
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

		// Token: 0x02008707 RID: 34567
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B27 RID: 84775
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014B28 RID: 84776
			public static VerifyTableAction <1>__Verify;
		}
	}
}
