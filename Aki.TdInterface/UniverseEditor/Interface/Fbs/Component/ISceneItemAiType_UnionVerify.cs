using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058BA RID: 22714
	public static class ISceneItemAiType_UnionVerify
	{
		// Token: 0x06026525 RID: 156965 RVA: 0x00548220 File Offset: 0x00546420
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
