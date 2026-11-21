using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A85 RID: 27269
	public static class IClientTpToStreamingTargetPointVerify
	{
		// Token: 0x0602ECB6 RID: 191670 RVA: 0x00660BBC File Offset: 0x0065EDBC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientTpToStreamingTargetPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientTpToStreamingTargetPointVerify.<>O.<0>__Verify = new VerifyTableAction(IClientTpToStreamingTargetSuccessEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IClientTpToStreamingTargetPointVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IClientTpToStreamingTargetPointVerify.<>O.<1>__Verify = new VerifyUnionAction(TTeleportTransitionOptionVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IClientTpToStreamingTargetPointVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IClientTpToStreamingTargetPointVerify.<>O.<2>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IClientTpToStreamingTargetPointVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IClientTpToStreamingTargetPointVerify.<>O.<2>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200859B RID: 34203
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401493D RID: 84285
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401493E RID: 84286
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x0401493F RID: 84287
			public static VerifyTableAction <2>__Verify;
		}
	}
}
