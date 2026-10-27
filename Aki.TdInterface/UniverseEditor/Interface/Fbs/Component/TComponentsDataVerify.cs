using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF9 RID: 23545
	public static class TComponentsDataVerify
	{
		// Token: 0x06028654 RID: 165460 RVA: 0x0058F99D File Offset: 0x0058DB9D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = TComponentsDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TComponentsDataVerify.<>O.<0>__Verify = new VerifyTableAction(TComponentDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C8F RID: 31887
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137BA RID: 79802
			public static VerifyTableAction <0>__Verify;
		}
	}
}
