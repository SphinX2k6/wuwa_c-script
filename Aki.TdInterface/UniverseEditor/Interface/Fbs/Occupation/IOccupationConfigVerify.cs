using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043AF RID: 17327
	public static class IOccupationConfigVerify
	{
		// Token: 0x06019CE9 RID: 105705 RVA: 0x003B1B44 File Offset: 0x003AFD44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short typeIdVOffset = 12;
				short valueVOffset = 14;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOccupationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOccupationConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TOccupationDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200798F RID: 31119
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401330F RID: 78607
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
