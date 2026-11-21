using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D3 RID: 26835
	public static class IBvbSendSystemEventVerify
	{
		// Token: 0x0602DEB4 RID: 188084 RVA: 0x00646A24 File Offset: 0x00644C24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbSendSystemEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbSendSystemEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TBvbEventDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200856F RID: 34159
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014903 RID: 84227
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
