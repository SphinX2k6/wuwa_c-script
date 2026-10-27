using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200519A RID: 20890
	public static class IEntityMatchConfig_UnionVerify
	{
		// Token: 0x06021CB2 RID: 138418 RVA: 0x004B01D0 File Offset: 0x004AE3D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEntityMatchConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntityMatchAllCharacterVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityMatchPlayerVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IEntityMatchDynamicVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IEntityMatchSpecificBpVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
