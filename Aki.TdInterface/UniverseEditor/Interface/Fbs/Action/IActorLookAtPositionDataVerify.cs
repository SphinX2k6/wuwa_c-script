using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060EB RID: 24811
	public static class IActorLookAtPositionDataVerify
	{
		// Token: 0x0602A62F RID: 173615 RVA: 0x005D72D8 File Offset: 0x005D54D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorLookAtPositionDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorLookAtPositionDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CD5 RID: 31957
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013808 RID: 79880
			public static VerifyTableAction <0>__Verify;
		}
	}
}
