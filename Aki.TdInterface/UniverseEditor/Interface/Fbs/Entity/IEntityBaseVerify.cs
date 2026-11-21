using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BFD RID: 19453
	public static class IEntityBaseVerify
	{
		// Token: 0x0601DBAD RID: 121773 RVA: 0x0042BBE0 File Offset: 0x00429DE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityBaseVerify.<>O.<0>__Verify = new VerifyTableAction(TComponentsDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200823C RID: 33340
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014407 RID: 82951
			public static VerifyTableAction <0>__Verify;
		}
	}
}
