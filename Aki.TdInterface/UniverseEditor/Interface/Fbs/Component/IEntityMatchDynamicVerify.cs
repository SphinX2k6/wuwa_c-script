using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200519D RID: 20893
	public static class IEntityMatchDynamicVerify
	{
		// Token: 0x06021CCE RID: 138446 RVA: 0x004B058C File Offset: 0x004AE78C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityMatchDynamicVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityMatchDynamicVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicEntityMatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AFE RID: 31486
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013522 RID: 79138
			public static VerifyTableAction <0>__Verify;
		}
	}
}
