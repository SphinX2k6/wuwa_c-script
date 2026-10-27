using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B4 RID: 22708
	public static class ISceneItemAiPatrolType_UnionVerify
	{
		// Token: 0x060264FB RID: 156923 RVA: 0x00547D00 File Offset: 0x00545F00
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
