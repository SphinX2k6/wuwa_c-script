using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005314 RID: 21268
	public static class IGraph3dEffectBase_UnionVerify
	{
		// Token: 0x06022BE3 RID: 142307 RVA: 0x004D0450 File Offset: 0x004CE650
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFireBoxFishEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGraph3dEffectBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
