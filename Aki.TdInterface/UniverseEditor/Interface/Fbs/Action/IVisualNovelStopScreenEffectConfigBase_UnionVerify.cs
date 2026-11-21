using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DEA RID: 32234
	public static class IVisualNovelStopScreenEffectConfigBase_UnionVerify
	{
		// Token: 0x0603A40A RID: 238602 RVA: 0x007D98B4 File Offset: 0x007D7AB4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IVisualNovelStopScreenEffectPersistentVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IVisualNovelStopScreenEffectConfigBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
