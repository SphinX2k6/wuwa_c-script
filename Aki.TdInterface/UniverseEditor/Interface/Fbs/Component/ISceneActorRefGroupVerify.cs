using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A2 RID: 22690
	public static class ISceneActorRefGroupVerify
	{
		// Token: 0x06026465 RID: 156773 RVA: 0x00546B28 File Offset: 0x00544D28
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

		// Token: 0x02007C17 RID: 31767
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136F5 RID: 79605
			public static VerifyTableAction <0>__Verify;
		}
	}
}
