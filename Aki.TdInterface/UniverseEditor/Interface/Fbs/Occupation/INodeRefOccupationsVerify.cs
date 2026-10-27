using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043A9 RID: 17321
	public static class INodeRefOccupationsVerify
	{
		// Token: 0x06019CA7 RID: 105639 RVA: 0x003B12D4 File Offset: 0x003AF4D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INodeRefOccupationsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INodeRefOccupationsVerify.<>O.<0>__Verify = new VerifyTableAction(INodeRefOccupationDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200798E RID: 31118
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401330E RID: 78606
			public static VerifyTableAction <0>__Verify;
		}
	}
}
