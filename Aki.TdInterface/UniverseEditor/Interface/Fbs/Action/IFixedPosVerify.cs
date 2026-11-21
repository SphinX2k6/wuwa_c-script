using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E50 RID: 28240
	public static class IFixedPosVerify
	{
		// Token: 0x06030C8C RID: 199820 RVA: 0x0069EE6C File Offset: 0x0069D06C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixedPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixedPosVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085E7 RID: 34279
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401499F RID: 84383
			public static VerifyTableAction <0>__Verify;
		}
	}
}
