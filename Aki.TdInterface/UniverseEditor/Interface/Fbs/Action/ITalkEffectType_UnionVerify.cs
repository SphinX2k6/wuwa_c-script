using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A90 RID: 31376
	public static class ITalkEffectType_UnionVerify
	{
		// Token: 0x060374EC RID: 226540 RVA: 0x00762720 File Offset: 0x00760920
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
