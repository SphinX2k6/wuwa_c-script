using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB6 RID: 28598
	public static class ISetAudioStateVerify
	{
		// Token: 0x060328B6 RID: 207030 RVA: 0x006D2285 File Offset: 0x006D0485
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetAudioStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetAudioStateVerify.<>O.<0>__Verify = new VerifyTableAction(IAudioStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E31 RID: 32305
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139EF RID: 80367
			public static VerifyTableAction <0>__Verify;
		}
	}
}
