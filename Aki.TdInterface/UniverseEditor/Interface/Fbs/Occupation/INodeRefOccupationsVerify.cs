using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200480B RID: 18443
	public static class INodeRefOccupationsVerify
	{
		// Token: 0x0601B435 RID: 111669 RVA: 0x003DCCFC File Offset: 0x003DAEFC
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

		// Token: 0x020081D7 RID: 33239
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014375 RID: 82805
			public static VerifyTableAction <0>__Verify;
		}
	}
}
