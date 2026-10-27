using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Entity;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200440E RID: 17422
	public static class ILevelDataVerify
	{
		// Token: 0x06019F19 RID: 106265 RVA: 0x003B5E25 File Offset: 0x003B4025
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelDataVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007994 RID: 31124
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013317 RID: 78615
			public static VerifyTableAction <0>__Verify;
		}
	}
}
