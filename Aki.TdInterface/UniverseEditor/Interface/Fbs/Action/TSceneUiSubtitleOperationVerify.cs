using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FA5 RID: 32677
	public static class TSceneUiSubtitleOperationVerify
	{
		// Token: 0x0603ADEA RID: 241130 RVA: 0x007E90DC File Offset: 0x007E72DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISpawnSceneUiSubtitleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRemoveSceneUiSubtitleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
