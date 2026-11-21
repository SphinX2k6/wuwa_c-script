using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200626C RID: 25196
	public static class TInteractEntityPartBindVerify
	{
		// Token: 0x0602AE1A RID: 175642 RVA: 0x005DA7D4 File Offset: 0x005D89D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IInteractEntityPartPrefabBindVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInteractEntityPartModelBindVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
