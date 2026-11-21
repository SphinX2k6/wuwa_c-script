using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200722D RID: 29229
	public static class IMontageConfig_UnionVerify
	{
		// Token: 0x06032DC3 RID: 208323 RVA: 0x006DDD94 File Offset: 0x006DBF94
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMontageConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMontageAssetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMontageRegisteredVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
