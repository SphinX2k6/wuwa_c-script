using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200683F RID: 26687
	public static class IFocusObjectRotationConfigVerify
	{
		// Token: 0x0602E884 RID: 190596 RVA: 0x00659668 File Offset: 0x00657868
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFocusObjectRotationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFocusObjectRotationConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D7C RID: 32124
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013902 RID: 80130
			public static VerifyTableAction <0>__Verify;
		}
	}
}
