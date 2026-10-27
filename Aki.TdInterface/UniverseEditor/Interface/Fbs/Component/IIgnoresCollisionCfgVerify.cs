using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E8 RID: 21480
	public static class IIgnoresCollisionCfgVerify
	{
		// Token: 0x0602346A RID: 144490 RVA: 0x004E279C File Offset: 0x004E099C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IIgnoresCollisionCfgVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IIgnoresCollisionCfgVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B62 RID: 31586
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135C4 RID: 79300
			public static VerifyTableAction <0>__Verify;
		}
	}
}
