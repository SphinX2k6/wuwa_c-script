using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E67 RID: 15975
	public static class ICommonHostToTargetDistanceVerify
	{
		// Token: 0x0601585C RID: 88156 RVA: 0x0031A6E4 File Offset: 0x003188E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonHostToTargetDistanceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonHostToTargetDistanceVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080B7 RID: 32951
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014136 RID: 82230
			public static VerifyTableAction <0>__Verify;
		}
	}
}
