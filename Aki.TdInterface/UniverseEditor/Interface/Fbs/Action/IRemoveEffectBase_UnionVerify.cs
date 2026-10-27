using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E4B RID: 28235
	public static class IRemoveEffectBase_UnionVerify
	{
		// Token: 0x06031E4B RID: 204363 RVA: 0x006C0564 File Offset: 0x006BE764
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
