using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004654 RID: 18004
	public static class ITrackEffectType_UnionVerify
	{
		// Token: 0x0601A613 RID: 108051 RVA: 0x003C1320 File Offset: 0x003BF520
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITrackEffectAutoChangeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITrackEffectTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
