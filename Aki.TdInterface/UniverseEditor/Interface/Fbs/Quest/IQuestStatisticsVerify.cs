using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200448F RID: 17551
	public static class IQuestStatisticsVerify
	{
		// Token: 0x06019435 RID: 103477 RVA: 0x0039AD54 File Offset: 0x00398F54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestStatisticsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestStatisticsVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonCalculateVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008184 RID: 33156
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142B7 RID: 82615
			public static VerifyTableAction <0>__Verify;
		}
	}
}
