using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004795 RID: 18325
	public static class IEntityBaseVerify
	{
		// Token: 0x0601C3D8 RID: 115672 RVA: 0x003FF944 File Offset: 0x003FDB44
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

		// Token: 0x020079F3 RID: 31219
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133A0 RID: 78752
			public static VerifyTableAction <0>__Verify;
		}
	}
}
