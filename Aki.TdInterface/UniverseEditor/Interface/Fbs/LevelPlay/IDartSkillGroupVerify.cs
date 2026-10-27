using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200448D RID: 17549
	public static class IDartSkillGroupVerify
	{
		// Token: 0x0601A2CD RID: 107213 RVA: 0x003BD281 File Offset: 0x003BB481
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDartSkillGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDartSkillGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IDartSkillVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079A3 RID: 31139
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401332C RID: 78636
			public static VerifyTableAction <0>__Verify;
		}
	}
}
