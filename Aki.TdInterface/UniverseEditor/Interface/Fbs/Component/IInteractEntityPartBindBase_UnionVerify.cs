using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005448 RID: 21576
	public static class IInteractEntityPartBindBase_UnionVerify
	{
		// Token: 0x060237BC RID: 145340 RVA: 0x004E8FBC File Offset: 0x004E71BC
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
