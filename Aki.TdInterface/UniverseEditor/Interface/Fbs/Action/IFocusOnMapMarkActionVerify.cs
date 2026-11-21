using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ECE RID: 28366
	public static class IFocusOnMapMarkActionVerify
	{
		// Token: 0x0603114A RID: 201034 RVA: 0x006A7C10 File Offset: 0x006A5E10
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

		// Token: 0x020085F4 RID: 34292
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149B0 RID: 84400
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
