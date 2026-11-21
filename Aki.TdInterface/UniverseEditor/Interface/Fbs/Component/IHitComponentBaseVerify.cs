using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005911 RID: 22801
	public static class IHitComponentBaseVerify
	{
		// Token: 0x06025111 RID: 151825 RVA: 0x00516744 File Offset: 0x00514944
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IHitComponentBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHitComponentBaseVerify.<>O.<0>__Verify = new VerifyUnionAction(THitBulletTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHitComponentBaseVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IHitComponentBaseVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IHitComponentBaseVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IHitComponentBaseVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IHitComponentBaseVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IHitComponentBaseVerify.<>O.<2>__Verify = new VerifyTableAction(IAimPartVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020083B4 RID: 33716
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401462C RID: 83500
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401462D RID: 83501
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401462E RID: 83502
			public static VerifyTableAction <2>__Verify;
		}
	}
}
