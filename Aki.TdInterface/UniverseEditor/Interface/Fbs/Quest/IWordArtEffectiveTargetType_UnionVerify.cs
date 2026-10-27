using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A9 RID: 17065
	public static class IWordArtEffectiveTargetType_UnionVerify
	{
		// Token: 0x06019494 RID: 103572 RVA: 0x003A1780 File Offset: 0x0039F980
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || INumberWordArtEffectiveTargetTypeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWordArtEffectiveTargetTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
