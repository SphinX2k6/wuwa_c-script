using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B7 RID: 30647
	public static class ISetExploreStateVerify
	{
		// Token: 0x06035D13 RID: 220435 RVA: 0x00735959 File Offset: 0x00733B59
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetExploreStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetExploreStateVerify.<>O.<0>__Verify = new VerifyTableAction(ITeleControlConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086CE RID: 34510
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014ACA RID: 84682
			public static VerifyTableAction <0>__Verify;
		}
	}
}
