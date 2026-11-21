using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EC7 RID: 24263
	public static class ISceneItemAiType_UnionVerify
	{
		// Token: 0x06028A87 RID: 166535 RVA: 0x0058ED6C File Offset: 0x0058CF6C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISceneItemPatrolVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISceneItemAiTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
