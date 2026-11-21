using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006933 RID: 26931
	public static class IChangeActorMaterialDataVerify
	{
		// Token: 0x0602E289 RID: 189065 RVA: 0x0064E8B0 File Offset: 0x0064CAB0
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

		// Token: 0x0200857D RID: 34173
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014916 RID: 84246
			public static VerifyTableAction <0>__Verify;
		}
	}
}
