using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005152 RID: 20818
	public static class IEntityAttachPointVerify
	{
		// Token: 0x060219A5 RID: 137637 RVA: 0x004A9E34 File Offset: 0x004A8034
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityAttachPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityAttachPointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AF2 RID: 31474
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013511 RID: 79121
			public static VerifyTableAction <0>__Verify;
		}
	}
}
