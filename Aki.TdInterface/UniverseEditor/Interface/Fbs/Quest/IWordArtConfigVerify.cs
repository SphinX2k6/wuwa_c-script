using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A0 RID: 17056
	public static class IWordArtConfigVerify
	{
		// Token: 0x0601945C RID: 103516 RVA: 0x003A1234 File Offset: 0x0039F434
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWordArtConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWordArtConfigVerify.<>O.<0>__Verify = new VerifyTableAction(INumberWordArtEffectiveTargetTypeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWordArtConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IWordArtConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IWordArtDefaultResourceTypeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007983 RID: 31107
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132FF RID: 78591
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013300 RID: 78592
			public static VerifyTableAction <1>__Verify;
		}
	}
}
