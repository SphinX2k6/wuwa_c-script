using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051C1 RID: 20929
	public static class IEntityTrackControlVerify
	{
		// Token: 0x06021EAF RID: 138927 RVA: 0x004B4914 File Offset: 0x004B2B14
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityTrackControlVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityTrackControlVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityTrackControlPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B07 RID: 31495
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013531 RID: 79153
			public static VerifyTableAction <0>__Verify;
		}
	}
}
