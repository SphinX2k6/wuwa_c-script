using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007168 RID: 29032
	public static class ISolarSchoolTimeVerify
	{
		// Token: 0x06033797 RID: 210839 RVA: 0x006EF3B4 File Offset: 0x006ED5B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISolarSchoolTimeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISolarSchoolTimeVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelDateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E67 RID: 32359
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A45 RID: 80453
			public static VerifyTableAction <0>__Verify;
		}
	}
}
