using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005756 RID: 22358
	public static class IPointChooseType_UnionVerify
	{
		// Token: 0x06025776 RID: 153462 RVA: 0x0052B564 File Offset: 0x00529764
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
