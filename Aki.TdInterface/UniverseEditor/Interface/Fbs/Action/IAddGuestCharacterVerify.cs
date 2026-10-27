using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200612D RID: 24877
	public static class IAddGuestCharacterVerify
	{
		// Token: 0x0602A86E RID: 174190 RVA: 0x005DB25C File Offset: 0x005D945C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAddGuestCharacterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAddGuestCharacterVerify.<>O.<0>__Verify = new VerifyTableAction(IActiveRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CDC RID: 31964
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013810 RID: 79888
			public static VerifyTableAction <0>__Verify;
		}
	}
}
