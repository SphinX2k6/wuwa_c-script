using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FB RID: 16891
	public static class ITrackEffectType_UnionVerify
	{
		// Token: 0x06018EB9 RID: 102073 RVA: 0x00395DC0 File Offset: 0x00393FC0
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
