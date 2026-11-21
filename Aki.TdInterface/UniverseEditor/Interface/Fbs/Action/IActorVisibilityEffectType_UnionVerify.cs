using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200677D RID: 26493
	public static class IActorVisibilityEffectType_UnionVerify
	{
		// Token: 0x0602CE75 RID: 183925 RVA: 0x006238D0 File Offset: 0x00621AD0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IActorVisibilityEffectDefaultVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IActorVisibilityEffectTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
