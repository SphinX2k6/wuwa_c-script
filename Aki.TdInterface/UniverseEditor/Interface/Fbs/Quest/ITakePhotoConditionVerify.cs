using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004603 RID: 17923
	public static class ITakePhotoConditionVerify
	{
		// Token: 0x0601A34F RID: 107343 RVA: 0x003BB7F0 File Offset: 0x003B99F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITakePhotoConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhotoConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITakePhotoConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITakePhotoConditionVerify.<>O.<1>__Verify = new VerifyTableAction(ITakePhotoTimeConditionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITakePhotoConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITakePhotoConditionVerify.<>O.<2>__Verify = new VerifyTableAction(ITakePhotoPosConditionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITakePhotoConditionVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITakePhotoConditionVerify.<>O.<3>__Verify = new VerifyTableAction(IPhotoTargetVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020081AB RID: 33195
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014323 RID: 82723
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014324 RID: 82724
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014325 RID: 82725
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014326 RID: 82726
			public static VerifyTableAction <3>__Verify;
		}
	}
}
