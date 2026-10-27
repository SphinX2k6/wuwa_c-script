using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062C2 RID: 25282
	public static class IChangeActorMaterialDataVerify
	{
		// Token: 0x0602BB20 RID: 178976 RVA: 0x006038A4 File Offset: 0x00601AA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChangeActorMaterialDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeActorMaterialDataVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D0A RID: 32010
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401386D RID: 79981
			public static VerifyTableAction <0>__Verify;
		}
	}
}
