using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C47 RID: 23623
	public static class TInteractEntityPartBindVerify
	{
		// Token: 0x0602880C RID: 165900 RVA: 0x005925BC File Offset: 0x005907BC
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
