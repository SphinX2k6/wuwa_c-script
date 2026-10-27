using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005089 RID: 20617
	public static class IDestructibleItemVerify
	{
		// Token: 0x06021166 RID: 135526 RVA: 0x00498F3C File Offset: 0x0049713C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDestructibleItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDestructibleItemVerify.<>O.<0>__Verify = new VerifyUnionAction(THitBulletTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDestructibleItemVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDestructibleItemVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDestructibleItemVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IDestructibleItemVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IDestructibleItemVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IDestructibleItemVerify.<>O.<2>__Verify = new VerifyTableAction(IAimPartVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false))
							{
								short offsetId4 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IDestructibleItemVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IDestructibleItemVerify.<>O.<3>__Verify = new VerifyTableAction(IDurabilityWornVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId4, verifyAction5, false))
								{
									short offsetId5 = 22;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IDestructibleItemVerify.<>O.<4>__Verify) == null)
									{
										verifyAction6 = (IDestructibleItemVerify.<>O.<4>__Verify = new VerifyTableAction(IDurabilityStateConfigVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false))
									{
										short offsetId6 = 24;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IDestructibleItemVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (IDestructibleItemVerify.<>O.<5>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId6, verifyAction7, false))
										{
											short offsetId7 = 26;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IDestructibleItemVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (IDestructibleItemVerify.<>O.<6>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction8, false))
											{
												short offsetId8 = 28;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IDestructibleItemVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (IDestructibleItemVerify.<>O.<7>__Verify = new VerifyTableAction(ISkillDamageVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId8, verifyAction9, false))
												{
													short offsetId9 = 30;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = IDestructibleItemVerify.<>O.<8>__Verify) == null)
													{
														verifyAction10 = (IDestructibleItemVerify.<>O.<8>__Verify = new VerifyTableAction(IElementDamageVerify.Verify));
													}
													if (verifier.VerifyTable(tablePos, offsetId9, verifyAction10, false))
													{
														short offsetId10 = 32;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = IDestructibleItemVerify.<>O.<9>__Verify) == null)
														{
															verifyAction11 = (IDestructibleItemVerify.<>O.<9>__Verify = new VerifyTableAction(IWeaponDamageVerify.Verify));
														}
														if (verifier.VerifyTable(tablePos, offsetId10, verifyAction11, false) && verifier.VerifyVectorOfData(tablePos, 34, 1UL, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false))
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
					}
				}
			}
			return false;
		}

		// Token: 0x02007AD3 RID: 31443
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134D2 RID: 79058
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040134D3 RID: 79059
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040134D4 RID: 79060
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040134D5 RID: 79061
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040134D6 RID: 79062
			public static VerifyTableAction <4>__Verify;

			// Token: 0x040134D7 RID: 79063
			public static VerifyTableAction <5>__Verify;

			// Token: 0x040134D8 RID: 79064
			public static VerifyTableAction <6>__Verify;

			// Token: 0x040134D9 RID: 79065
			public static VerifyTableAction <7>__Verify;

			// Token: 0x040134DA RID: 79066
			public static VerifyTableAction <8>__Verify;

			// Token: 0x040134DB RID: 79067
			public static VerifyTableAction <9>__Verify;
		}
	}
}
