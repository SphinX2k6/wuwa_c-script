using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E5D RID: 28253
	public static class IRemovePreloadResourceActionVerify
	{
		// Token: 0x06031ED1 RID: 204497 RVA: 0x006C13EC File Offset: 0x006BF5EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRemovePreloadResourceActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRemovePreloadResourceActionVerify.<>O.<0>__Verify = new VerifyUnionAction(TRemovePreloadResourceConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E0F RID: 32271
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139CA RID: 80330
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
