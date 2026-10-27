using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065C0 RID: 26048
	public static class IDetectBattleTagType_UnionVerify
	{
		// Token: 0x0602D2DE RID: 185054 RVA: 0x00631B64 File Offset: 0x0062FD64
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDetectBattleMonsterOnGroundVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDetectBattleTagTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
