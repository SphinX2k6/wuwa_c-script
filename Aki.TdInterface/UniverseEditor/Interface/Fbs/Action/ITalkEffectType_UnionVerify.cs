using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072BB RID: 29371
	public static class ITalkEffectType_UnionVerify
	{
		// Token: 0x060341E8 RID: 213480 RVA: 0x00701384 File Offset: 0x006FF584
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITalkCommonEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITalkEffectTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
