using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004811 RID: 18449
	public static class IOccupationConfigVerify
	{
		// Token: 0x0601B478 RID: 111736 RVA: 0x003DD5C4 File Offset: 0x003DB7C4
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

		// Token: 0x020081D8 RID: 33240
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014376 RID: 82806
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
