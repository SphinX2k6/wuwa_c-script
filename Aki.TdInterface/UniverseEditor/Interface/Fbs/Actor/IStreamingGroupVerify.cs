using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02006545 RID: 25925
	public static class IStreamingGroupVerify
	{
		// Token: 0x0602C32B RID: 181035 RVA: 0x00604DD4 File Offset: 0x00602FD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStreamingGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStreamingGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008538 RID: 34104
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401489D RID: 84125
			public static VerifyTableAction <0>__Verify;
		}
	}
}
