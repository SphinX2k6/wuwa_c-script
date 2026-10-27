using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F2F RID: 28463
	public static class ISceneInspectionVerify
	{
		// Token: 0x060324A2 RID: 205986 RVA: 0x006CADD0 File Offset: 0x006C8FD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneInspectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneInspectionVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneInspectionPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E21 RID: 32289
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139DD RID: 80349
			public static VerifyTableAction <0>__Verify;
		}
	}
}
