using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200611B RID: 24859
	public static class IActorVisibilityEffectType_UnionVerify
	{
		// Token: 0x0602A794 RID: 173972 RVA: 0x005D9928 File Offset: 0x005D7B28
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
