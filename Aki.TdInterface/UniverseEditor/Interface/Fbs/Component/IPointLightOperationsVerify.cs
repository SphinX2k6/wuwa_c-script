using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005768 RID: 22376
	public static class IPointLightOperationsVerify
	{
		// Token: 0x060257FA RID: 153594 RVA: 0x0052C4F0 File Offset: 0x0052A6F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPointLightOperationsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPointLightOperationsVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityMatchVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BDE RID: 31710
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136A2 RID: 79522
			public static VerifyTableAction <0>__Verify;
		}
	}
}
