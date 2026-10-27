using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006262 RID: 25186
	public static class IBvbSendSystemEventVerify
	{
		// Token: 0x0602B753 RID: 178003 RVA: 0x005FBC1C File Offset: 0x005F9E1C
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

		// Token: 0x02007CFC RID: 31996
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401385B RID: 79963
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
