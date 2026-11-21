using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B2F RID: 27439
	public static class IConeRangeCheckVerify
	{
		// Token: 0x0602F36F RID: 193391 RVA: 0x00672980 File Offset: 0x00670B80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConeRangeCheckVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConeRangeCheckVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085AA RID: 34218
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401494F RID: 84303
			public static VerifyTableAction <0>__Verify;
		}
	}
}
