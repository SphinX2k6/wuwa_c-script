using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200457D RID: 17789
	public static class IRollBlockGridQuantumVerify
	{
		// Token: 0x0601ADE8 RID: 110056 RVA: 0x003D5DA8 File Offset: 0x003D3FA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRollBlockGridQuantumVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockGridQuantumVerify.<>O.<0>__Verify = new VerifyUnionAction(TRollBlockVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079C1 RID: 31169
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401335C RID: 78684
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
