using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D5D RID: 23901
	public static class IPointChooseType_UnionVerify
	{
		// Token: 0x06027C96 RID: 162966 RVA: 0x005716F0 File Offset: 0x0056F8F0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISpawnMonsterPointVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPointChooseTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
