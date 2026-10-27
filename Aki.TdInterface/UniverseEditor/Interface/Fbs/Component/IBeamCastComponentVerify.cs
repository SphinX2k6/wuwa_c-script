using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F03 RID: 20227
	public static class IBeamCastComponentVerify
	{
		// Token: 0x0601FF81 RID: 130945 RVA: 0x00472FF4 File Offset: 0x004711F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBeamCastComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBeamCastComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ICylinderTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBeamCastComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IBeamCastComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IBeamReflectionConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						short offsetId3 = 22;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IBeamCastComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IBeamCastComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IBeamLayoutConfigWallVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IBeamCastComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IBeamCastComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007A8C RID: 31372
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013467 RID: 78951
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013468 RID: 78952
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013469 RID: 78953
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401346A RID: 78954
			public static VerifyTableAction <3>__Verify;
		}
	}
}
