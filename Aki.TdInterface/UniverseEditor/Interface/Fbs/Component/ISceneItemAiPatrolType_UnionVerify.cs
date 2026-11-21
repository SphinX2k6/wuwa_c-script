using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EC1 RID: 24257
	public static class ISceneItemAiPatrolType_UnionVerify
	{
		// Token: 0x06028A5D RID: 166493 RVA: 0x0058E84C File Offset: 0x0058CA4C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISceneItemAiPatrolByGameTimeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISceneItemAiPatrolTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
