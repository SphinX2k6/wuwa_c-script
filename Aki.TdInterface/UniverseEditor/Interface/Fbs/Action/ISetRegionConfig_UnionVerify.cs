using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007063 RID: 28771
	public static class ISetRegionConfig_UnionVerify
	{
		// Token: 0x06032F13 RID: 208659 RVA: 0x006DF69C File Offset: 0x006DD89C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetRegionMpcVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISetRegionConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
