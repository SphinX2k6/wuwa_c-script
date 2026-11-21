using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200780B RID: 30731
	public static class ISetNpcSequencePerformVerify
	{
		// Token: 0x06036008 RID: 221192 RVA: 0x0073BC5C File Offset: 0x00739E5C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetNpcSequencePerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNpcSequencePerformVerify.<>O.<0>__Verify = new VerifyTableAction(INpcGroupSequencePlaySettingVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISetNpcSequencePerformVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISetNpcSequencePerformVerify.<>O.<1>__Verify = new VerifyTableAction(INpcGroupSequenceStaticEntityBindingVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISetNpcSequencePerformVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ISetNpcSequencePerformVerify.<>O.<2>__Verify = new VerifyTableAction(INpcGroupSequenceBlendAnimVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020086DC RID: 34524
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AE3 RID: 84707
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014AE4 RID: 84708
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014AE5 RID: 84709
			public static VerifyTableAction <2>__Verify;
		}
	}
}
