using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006596 RID: 26006
	public static class IDestroyPrefabVerify
	{
		// Token: 0x0602D1C8 RID: 184776 RVA: 0x0063012C File Offset: 0x0062E32C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDestroyPrefabVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDestroyPrefabVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D3E RID: 32062
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138B3 RID: 80051
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
