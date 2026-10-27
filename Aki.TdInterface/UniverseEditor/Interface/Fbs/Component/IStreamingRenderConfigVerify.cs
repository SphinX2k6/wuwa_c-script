using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D0 RID: 22992
	public static class IStreamingRenderConfigVerify
	{
		// Token: 0x06027017 RID: 159767 RVA: 0x0055E21C File Offset: 0x0055C41C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IStreamingRenderConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStreamingRenderConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TPortalViewDistanceConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IStreamingRenderConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IStreamingRenderConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 10, 2UL, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IStreamingRenderConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IStreamingRenderConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IStreamingRtEffectRefVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IStreamingRenderConfigVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IStreamingRenderConfigVerify.<>O.<3>__Verify = new VerifyTableAction(IRtSizeVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C43 RID: 31811
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013738 RID: 79672
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013739 RID: 79673
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401373A RID: 79674
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401373B RID: 79675
			public static VerifyTableAction <3>__Verify;
		}
	}
}
