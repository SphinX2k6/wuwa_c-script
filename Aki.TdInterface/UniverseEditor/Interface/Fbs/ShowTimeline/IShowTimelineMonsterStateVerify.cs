using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FCF RID: 16335
	public static class IShowTimelineMonsterStateVerify
	{
		// Token: 0x06016534 RID: 91444 RVA: 0x00332C00 File Offset: 0x00330E00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowTimelineMonsterStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowTimelineMonsterStateVerify.<>O.<0>__Verify = new VerifyTableAction(ITransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 8UL, false) && verifier.VerifyVectorOfStrings(tablePos, 14, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080D4 RID: 32980
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014159 RID: 82265
			public static VerifyTableAction <0>__Verify;
		}
	}
}
