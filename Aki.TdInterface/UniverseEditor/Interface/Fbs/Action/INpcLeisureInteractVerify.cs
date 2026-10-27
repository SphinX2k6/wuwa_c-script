using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC0 RID: 27584
	public static class INpcLeisureInteractVerify
	{
		// Token: 0x0603074E RID: 198478 RVA: 0x006948F8 File Offset: 0x00692AF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INpcLeisureInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcLeisureInteractVerify.<>O.<0>__Verify = new VerifyUnionAction(TNpcLeisureInteractOpVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DC8 RID: 32200
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401396C RID: 80236
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
