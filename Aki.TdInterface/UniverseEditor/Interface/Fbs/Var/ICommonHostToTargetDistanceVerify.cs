using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A8C RID: 14988
	public static class ICommonHostToTargetDistanceVerify
	{
		// Token: 0x06014540 RID: 83264 RVA: 0x002F74F8 File Offset: 0x002F56F8
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

		// Token: 0x02007879 RID: 30841
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130E1 RID: 78049
			public static VerifyTableAction <0>__Verify;
		}
	}
}
