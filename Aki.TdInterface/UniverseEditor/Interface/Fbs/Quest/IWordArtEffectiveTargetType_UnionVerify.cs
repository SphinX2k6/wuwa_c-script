using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004705 RID: 18181
	public static class IWordArtEffectiveTargetType_UnionVerify
	{
		// Token: 0x0601AC00 RID: 109568 RVA: 0x003CCE58 File Offset: 0x003CB058
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
