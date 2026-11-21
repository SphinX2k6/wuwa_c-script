using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F30 RID: 16176
	public static class IWoodenBoxProliferateParamsVerify
	{
		// Token: 0x06015FE6 RID: 90086 RVA: 0x00328FC0 File Offset: 0x003271C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IWoodenBoxProliferateParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWoodenBoxProliferateParamsVerify.<>O.<0>__Verify = new VerifyUnionAction(TWoodenBoxProliferateSpawnConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080C8 RID: 32968
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014149 RID: 82249
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
