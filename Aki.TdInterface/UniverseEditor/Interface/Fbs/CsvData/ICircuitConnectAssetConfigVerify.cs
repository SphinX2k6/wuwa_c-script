using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D6F RID: 19823
	public static class ICircuitConnectAssetConfigVerify
	{
		// Token: 0x0601EB94 RID: 125844 RVA: 0x0044C24C File Offset: 0x0044A44C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICircuitConnectAssetConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICircuitConnectAssetConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TCircuitConnectAssetTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008264 RID: 33380
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014442 RID: 83010
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
