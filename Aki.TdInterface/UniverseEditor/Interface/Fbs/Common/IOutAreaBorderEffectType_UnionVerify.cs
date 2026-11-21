using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200645A RID: 25690
	public static class IOutAreaBorderEffectType_UnionVerify
	{
		// Token: 0x0602BA85 RID: 178821 RVA: 0x005F137C File Offset: 0x005EF57C
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
