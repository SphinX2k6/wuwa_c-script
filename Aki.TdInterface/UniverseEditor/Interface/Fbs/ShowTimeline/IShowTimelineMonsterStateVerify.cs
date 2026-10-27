using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BC7 RID: 15303
	public static class IShowTimelineMonsterStateVerify
	{
		// Token: 0x0601505C RID: 86108 RVA: 0x0030C3A4 File Offset: 0x0030A5A4
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

		// Token: 0x02007890 RID: 30864
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130FD RID: 78077
			public static VerifyTableAction <0>__Verify;
		}
	}
}
