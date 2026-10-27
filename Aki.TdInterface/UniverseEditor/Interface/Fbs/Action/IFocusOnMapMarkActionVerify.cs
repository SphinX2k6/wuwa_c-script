using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006848 RID: 26696
	public static class IFocusOnMapMarkActionVerify
	{
		// Token: 0x0602E8C2 RID: 190658 RVA: 0x00659CD0 File Offset: 0x00657ED0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFocusOnMapMarkActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFocusOnMapMarkActionVerify.<>O.<0>__Verify = new VerifyUnionAction(TFocusOnMapMarkTypeConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D7D RID: 32125
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013903 RID: 80131
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
