using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048F5 RID: 18677
	public static class IDartSkillGroupVerify
	{
		// Token: 0x0601BA9E RID: 113310 RVA: 0x003E948D File Offset: 0x003E768D
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

		// Token: 0x020081EC RID: 33260
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014393 RID: 82835
			public static VerifyTableAction <0>__Verify;
		}
	}
}
