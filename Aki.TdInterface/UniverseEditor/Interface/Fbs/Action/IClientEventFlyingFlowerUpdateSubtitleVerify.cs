using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A10 RID: 27152
	public static class IClientEventFlyingFlowerUpdateSubtitleVerify
	{
		// Token: 0x0602E954 RID: 190804 RVA: 0x0065A5C8 File Offset: 0x006587C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientEventFlyingFlowerUpdateSubtitleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientEventFlyingFlowerUpdateSubtitleVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200858E RID: 34190
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401492F RID: 84271
			public static VerifyTableAction <0>__Verify;
		}
	}
}
