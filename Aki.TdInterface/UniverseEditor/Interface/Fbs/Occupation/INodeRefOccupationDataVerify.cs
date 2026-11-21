using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004808 RID: 18440
	public static class INodeRefOccupationDataVerify
	{
		// Token: 0x0601B419 RID: 111641 RVA: 0x003DC914 File Offset: 0x003DAB14
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INodeRefOccupationDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INodeRefOccupationDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TRefSourceDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081D6 RID: 33238
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014374 RID: 82804
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
