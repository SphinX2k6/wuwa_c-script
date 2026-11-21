using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200683D RID: 26685
	public static class IAwakeEntityVerify
	{
		// Token: 0x0602D9CC RID: 186828 RVA: 0x0063D9D8 File Offset: 0x0063BBD8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAwakeEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAwakeEntityVerify.<>O.<0>__Verify = new VerifyTableAction(IAwakeWithTransformVarVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008566 RID: 34150
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148FA RID: 84218
			public static VerifyTableAction <0>__Verify;
		}
	}
}
