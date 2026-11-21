using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C9 RID: 30153
	public static class IRemoveEffectBase_UnionVerify
	{
		// Token: 0x06034E61 RID: 216673 RVA: 0x0071BEEC File Offset: 0x0071A0EC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRemoveScreenEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRemoveEffectBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
