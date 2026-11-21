using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B5A RID: 23386
	public static class IMotorHookEndDirVerify
	{
		// Token: 0x060267D3 RID: 157651 RVA: 0x005455D0 File Offset: 0x005437D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorHookEndDirVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorHookEndDirVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083FB RID: 33787
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146BB RID: 83643
			public static VerifyTableAction <0>__Verify;
		}
	}
}
