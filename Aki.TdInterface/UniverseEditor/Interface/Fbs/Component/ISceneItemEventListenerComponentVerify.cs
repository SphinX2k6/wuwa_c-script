using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C3 RID: 22723
	public static class ISceneItemEventListenerComponentVerify
	{
		// Token: 0x0602658F RID: 157071 RVA: 0x00548F20 File Offset: 0x00547120
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneItemEventListenerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneItemEventListenerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneItemEventConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C1D RID: 31773
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136FC RID: 79612
			public static VerifyTableAction <0>__Verify;
		}
	}
}
