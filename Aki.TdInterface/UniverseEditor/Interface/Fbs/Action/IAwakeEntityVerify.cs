using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061CF RID: 25039
	public static class IAwakeEntityVerify
	{
		// Token: 0x0602B285 RID: 176773 RVA: 0x005F2F64 File Offset: 0x005F1164
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

		// Token: 0x02007CF4 RID: 31988
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013853 RID: 79955
			public static VerifyTableAction <0>__Verify;
		}
	}
}
