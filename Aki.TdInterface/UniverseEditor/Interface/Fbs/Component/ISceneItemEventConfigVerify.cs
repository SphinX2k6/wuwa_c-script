using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C0 RID: 22720
	public static class ISceneItemEventConfigVerify
	{
		// Token: 0x0602656F RID: 157039 RVA: 0x00548AEC File Offset: 0x00546CEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneItemEventConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneItemEventConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneItemSequenceEventDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C1C RID: 31772
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136FB RID: 79611
			public static VerifyTableAction <0>__Verify;
		}
	}
}
