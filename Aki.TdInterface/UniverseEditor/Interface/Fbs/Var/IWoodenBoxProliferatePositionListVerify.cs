using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F33 RID: 16179
	public static class IWoodenBoxProliferatePositionListVerify
	{
		// Token: 0x06016002 RID: 90114 RVA: 0x003293CC File Offset: 0x003275CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWoodenBoxProliferatePositionListVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWoodenBoxProliferatePositionListVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080C9 RID: 32969
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401414A RID: 82250
			public static VerifyTableAction <0>__Verify;
		}
	}
}
