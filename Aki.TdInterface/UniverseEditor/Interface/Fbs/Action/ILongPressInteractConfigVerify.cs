using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007162 RID: 29026
	public static class ILongPressInteractConfigVerify
	{
		// Token: 0x0603272D RID: 206637 RVA: 0x006D1B70 File Offset: 0x006CFD70
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILongPressInteractConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILongPressInteractConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ILongPressEffectConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ILongPressInteractConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILongPressInteractConfigVerify.<>O.<1>__Verify = new VerifyUnionAction(TLongPressInteractStyleConfigVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short offsetId2 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ILongPressInteractConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ILongPressInteractConfigVerify.<>O.<2>__Verify = new VerifyTableAction(ILongPressButtonActionMappingVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ILongPressInteractConfigVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ILongPressInteractConfigVerify.<>O.<3>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction4, false))
							{
								short offsetId4 = 18;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ILongPressInteractConfigVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (ILongPressInteractConfigVerify.<>O.<3>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction5, false))
								{
									short offsetId5 = 20;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ILongPressInteractConfigVerify.<>O.<3>__Verify) == null)
									{
										verifyAction6 = (ILongPressInteractConfigVerify.<>O.<3>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
									}
									if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction6, false))
									{
										short offsetId6 = 22;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ILongPressInteractConfigVerify.<>O.<4>__Verify) == null)
										{
											verifyAction7 = (ILongPressInteractConfigVerify.<>O.<4>__Verify = new VerifyTableAction(ILongPressProgressActionVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId6, verifyAction7, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
										{
											return verifier.VerifyTableEnd(tablePos);
										}
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200861F RID: 34335
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149E9 RID: 84457
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040149EA RID: 84458
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040149EB RID: 84459
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040149EC RID: 84460
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040149ED RID: 84461
			public static VerifyTableAction <4>__Verify;
		}
	}
}
