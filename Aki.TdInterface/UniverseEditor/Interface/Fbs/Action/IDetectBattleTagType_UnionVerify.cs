using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C28 RID: 27688
	public static class IDetectBattleTagType_UnionVerify
	{
		// Token: 0x0602FA62 RID: 195170 RVA: 0x0067DD28 File Offset: 0x0067BF28
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
