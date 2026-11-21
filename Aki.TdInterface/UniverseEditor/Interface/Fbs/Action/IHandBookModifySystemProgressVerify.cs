using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F64 RID: 28516
	public static class IHandBookModifySystemProgressVerify
	{
		// Token: 0x060315BF RID: 202175 RVA: 0x006B1D44 File Offset: 0x006AFF44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IHandBookModifySystemProgressVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHandBookModifySystemProgressVerify.<>O.<0>__Verify = new VerifyUnionAction(THandBookProgressOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085FE RID: 34302
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149BB RID: 84411
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
