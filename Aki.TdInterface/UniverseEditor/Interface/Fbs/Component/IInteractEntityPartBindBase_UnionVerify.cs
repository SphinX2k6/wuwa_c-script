using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059CE RID: 22990
	public static class IInteractEntityPartBindBase_UnionVerify
	{
		// Token: 0x06025874 RID: 153716 RVA: 0x00526030 File Offset: 0x00524230
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInteractEntityPartBindBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInteractEntityPartPrefabBindVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInteractEntityPartModelBindVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
