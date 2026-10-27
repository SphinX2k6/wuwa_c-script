using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F63 RID: 20323
	public static class ICategoryMatchingConditionVerify
	{
		// Token: 0x060203B0 RID: 132016 RVA: 0x0047C074 File Offset: 0x0047A274
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICategoryMatchingConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICategoryMatchingConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicEntityMatchVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AA0 RID: 31392
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013483 RID: 78979
			public static VerifyTableAction <0>__Verify;
		}
	}
}
