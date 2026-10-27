using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200561C RID: 22044
	public static class INpcBumpShowVerify
	{
		// Token: 0x0602495C RID: 149852 RVA: 0x0050C361 File Offset: 0x0050A561
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcBumpShowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcBumpShowVerify.<>O.<0>__Verify = new VerifyTableAction(INpcPerformBubbleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BA8 RID: 31656
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401363F RID: 79423
			public static VerifyTableAction <0>__Verify;
		}
	}
}
