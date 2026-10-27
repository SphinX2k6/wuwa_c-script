using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DB RID: 22747
	public static class ISceneTextComponentVerify
	{
		// Token: 0x0602667F RID: 157311 RVA: 0x0054AF00 File Offset: 0x00549100
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneTextComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneTextComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAndRotVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset = 10;
					short valueVOffset = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ISceneTextComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISceneTextComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TSceneTextVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C22 RID: 31778
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013704 RID: 79620
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013705 RID: 79621
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
