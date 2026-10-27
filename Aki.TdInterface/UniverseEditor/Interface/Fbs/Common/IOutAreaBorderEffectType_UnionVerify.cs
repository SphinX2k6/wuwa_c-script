using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E1D RID: 24093
	public static class IOutAreaBorderEffectType_UnionVerify
	{
		// Token: 0x060293FB RID: 168955 RVA: 0x005A864C File Offset: 0x005A684C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IOutAreaBorderBuffEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IOutAreaBorderEffectTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
