using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B5B RID: 15195
	public static class TTargetTypeVerify
	{
		// Token: 0x06014C92 RID: 85138 RVA: 0x00305178 File Offset: 0x00303378
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITargetPlayVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITargetLevelEntityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
