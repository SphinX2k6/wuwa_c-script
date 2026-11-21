using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FD5 RID: 16341
	public static class IShowTimelineRoleStateVerify
	{
		// Token: 0x060165A0 RID: 91552 RVA: 0x00333A80 File Offset: 0x00331C80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowTimelineRoleStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowTimelineRoleStateVerify.<>O.<0>__Verify = new VerifyTableAction(ITransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 8UL, false) && verifier.VerifyVectorOfStrings(tablePos, 14, false) && verifier.VerifyVectorOfStrings(tablePos, 16, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080D5 RID: 32981
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401415A RID: 82266
			public static VerifyTableAction <0>__Verify;
		}
	}
}
