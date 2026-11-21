using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EAF RID: 24239
	public static class ISceneActorRefGroupVerify
	{
		// Token: 0x060289C7 RID: 166343 RVA: 0x0058D674 File Offset: 0x0058B874
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneActorRefGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneActorRefGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008486 RID: 33926
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014797 RID: 83863
			public static VerifyTableAction <0>__Verify;
		}
	}
}
