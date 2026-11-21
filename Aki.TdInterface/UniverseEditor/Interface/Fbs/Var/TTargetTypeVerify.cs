using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F63 RID: 16227
	public static class TTargetTypeVerify
	{
		// Token: 0x0601615C RID: 90460 RVA: 0x0032B710 File Offset: 0x00329910
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
