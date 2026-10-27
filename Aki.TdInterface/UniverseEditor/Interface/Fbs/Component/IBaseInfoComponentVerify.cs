using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EEB RID: 20203
	public static class IBaseInfoComponentVerify
	{
		// Token: 0x0601FE4A RID: 130634 RVA: 0x0047013C File Offset: 0x0046E33C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBaseInfoComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBaseInfoComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityCategoryVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBaseInfoComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IBaseInfoComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IEntityScanFunctionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
					{
						short offsetId3 = 26;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IBaseInfoComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IBaseInfoComponentVerify.<>O.<2>__Verify = new VerifyTableAction(ICustomAoizRadiusVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 28, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 32, false))
						{
							short offsetId4 = 34;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IBaseInfoComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IBaseInfoComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IHeadStateViewConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 36, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 38, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 46, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 48, 4UL, false) && verifier.VerifyField(tablePos, 50, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 52, false))
							{
								short offsetId5 = 54;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IBaseInfoComponentVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IBaseInfoComponentVerify.<>O.<4>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 56, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 60, 1UL, 1UL, false))
								{
									short offsetId6 = 62;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IBaseInfoComponentVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (IBaseInfoComponentVerify.<>O.<5>__Verify = new VerifyTableAction(IEntityGravityConfigVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 64;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IBaseInfoComponentVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (IBaseInfoComponentVerify.<>O.<6>__Verify = new VerifyTableAction(IHeadInfoChangeDataVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction7, false) && verifier.VerifyField(tablePos, 66, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 68, 1UL, 1UL, false))
										{
											short offsetId8 = 70;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IBaseInfoComponentVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (IBaseInfoComponentVerify.<>O.<7>__Verify = new VerifyTableAction(IEntityAttachPointVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction8, false) && verifier.VerifyField(tablePos, 72, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 74, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 76, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 78, 4UL, 4UL, false))
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
			}
			return false;
		}

		// Token: 0x02007A87 RID: 31367
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401345A RID: 78938
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401345B RID: 78939
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401345C RID: 78940
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401345D RID: 78941
			public static VerifyTableAction <3>__Verify;

			// Token: 0x0401345E RID: 78942
			public static VerifyTableAction <4>__Verify;

			// Token: 0x0401345F RID: 78943
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04013460 RID: 78944
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04013461 RID: 78945
			public static VerifyTableAction <7>__Verify;
		}
	}
}
