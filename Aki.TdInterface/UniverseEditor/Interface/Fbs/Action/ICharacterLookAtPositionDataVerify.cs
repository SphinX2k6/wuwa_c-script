using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069BF RID: 27071
	public static class ICharacterLookAtPositionDataVerify
	{
		// Token: 0x0602E6FF RID: 190207 RVA: 0x00656168 File Offset: 0x00654368
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICharacterLookAtPositionDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICharacterLookAtPositionDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008587 RID: 34183
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014921 RID: 84257
			public static VerifyTableAction <0>__Verify;
		}
	}
}
