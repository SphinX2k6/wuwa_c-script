using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ECD RID: 24269
	public static class ISceneItemEventConfigVerify
	{
		// Token: 0x06028AD1 RID: 166609 RVA: 0x0058F638 File Offset: 0x0058D838
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneItemEventConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneItemEventConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneItemSequenceEventDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200848B RID: 33931
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401479D RID: 83869
			public static VerifyTableAction <0>__Verify;
		}
	}
}
